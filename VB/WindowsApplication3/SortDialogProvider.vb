Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.XtraGrid.Columns
Imports WindowsApplication3.Properties

Namespace DXSample
	 Public Class SortDialogProvider
		 Private view As GridView
		 Private showSortIndexInColumnHeader_Renamed As Boolean = True
		 Public Sub New(ByVal view As GridView)
			 Me.view = view
		 End Sub

		 Public Sub EnableSortDialog()
			 AddHandler view.PopupMenuShowing, AddressOf OnPopupMenuShowing
			 AddHandler view.CustomDrawColumnHeader, AddressOf OnCustomDrawColumnHeader
		 End Sub

		 Public Property ShowSortIndexInColumnHeader() As Boolean
			 Get
				 Return showSortIndexInColumnHeader_Renamed
			 End Get
			 Set(ByVal value As Boolean)
				 If showSortIndexInColumnHeader_Renamed <> value Then
					 showSortIndexInColumnHeader_Renamed = value
					 For Each col As GridColumn In view.SortedColumns
						 view.InvalidateColumnHeader(col)
					 Next col
				 End If
			 End Set
		 End Property

		 Private Sub OnCustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs)
			 If (Not ShowSortIndexInColumnHeader) OrElse e.Column Is Nothing OrElse e.Column.SortIndex = -1 Then
				 Return
			 End If
			 Dim args As GridColumnInfoArgs = TryCast(e.Info, GridColumnInfoArgs)
			 e.Painter.DrawObject(args)
			 Dim sortArgs As SortedShapeObjectInfoArgs = CType(args.InnerElements.Find(GetType(SortedShapeObjectInfoArgs)).ElementInfo, SortedShapeObjectInfoArgs)
			 Dim sortRectangle As Rectangle = sortArgs.Bounds
			 Dim sortIndexRectangle As New Rectangle(sortRectangle.X - 8, args.CaptionRect.Y, 10, args.CaptionRect.Height)
			 Dim brush As SolidBrush = TryCast(e.Appearance.GetBackBrush(e.Cache), SolidBrush)
			 brush.Color = Color.FromArgb(150, brush.Color)
			 Dim sortIndexShapeRectangle As New Rectangle(sortIndexRectangle.X - 2, sortIndexRectangle.Y, sortIndexRectangle.Width + sortRectangle.Width, sortIndexRectangle.Height)
			 e.Graphics.FillRectangle(brush, sortIndexShapeRectangle)
			 e.Appearance.DrawString(e.Cache, e.Column.SortIndex.ToString(), sortIndexRectangle)
			 e.Handled = True
		 End Sub

		 Private Sub OnPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			 Dim menu As GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
			 If menu Is Nothing Then
				 Return
			 End If
            menu.Items.Add(New DXMenuItem("Show Sort Dialog", AddressOf OnItemClick, Global.My.Resources.SortDialog))
		 End Sub

		 Private Sub OnItemClick(ByVal sender As Object, ByVal e As EventArgs)
			 Using f As New SortForm(view)
				 If f.ShowDialog() = DialogResult.OK Then
					 f.SaveChanges()
				 End If
			 End Using
		 End Sub

		 Public Sub DisableSortDialog()
			 RemoveHandler view.PopupMenuShowing, AddressOf OnPopupMenuShowing
			 RemoveHandler view.CustomDrawColumnHeader, AddressOf OnCustomDrawColumnHeader
		 End Sub
	 End Class
End Namespace
