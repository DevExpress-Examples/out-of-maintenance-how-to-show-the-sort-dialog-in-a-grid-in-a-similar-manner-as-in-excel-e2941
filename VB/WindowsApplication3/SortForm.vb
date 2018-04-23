Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections

Namespace DXSample
	Partial Public Class SortForm
		Inherits DevExpress.XtraEditors.XtraForm

		Private view As GridView
		Public Sub New(ByVal view As GridView)
			InitializeComponent()
			StartPosition = FormStartPosition.CenterParent
			Me.view = view
		End Sub

		Private Sub SortForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			SetUpRepositories()
			PopulateTree()
		End Sub

		Private Sub SetUpRepositories()
			repositoryItemImageComboBox1.Items.AddEnum(GetType(ColumnSortOrder))
			repositoryItemImageComboBox2.Items.AddEnum(GetType(ColumnSortMode))

			Dim columns As New ArrayList()
			For Each col As GridColumn In view.VisibleColumns
				If col.SortIndex = -1 Then
					columns.Add(col)
				End If
			Next col
			repositoryItemComboBox1.Items.AddRange(columns)
		End Sub

		Private Sub PopulateTree()
			For Each col As GridColumn In view.SortedColumns
                sortTree.AppendNode(New Object() {col, col.SortMode, col.SortOrder}, -1)
            Next col
		End Sub


		Private Sub OnAddLevel(ByVal sender As Object, ByVal e As EventArgs) Handles addLevelButton.Click
            sortTree.AppendNode(New Object() {Nothing, ColumnSortMode.Default, ColumnSortOrder.None}, -1)
        End Sub

		Private Sub OnDeleteLevel(ByVal sender As Object, ByVal e As EventArgs) Handles deleteLevelButton.Click
			sortTree.DeleteNode(sortTree.FocusedNode)
		End Sub

		Public Sub SaveChanges()
			view.BeginSort()
			view.ClearSorting()

			For Each node As TreeListNode In sortTree.Nodes
				Dim column As GridColumn = TryCast(node("Column"), GridColumn)
				If column Is Nothing Then
					Continue For
				End If
				Dim sortMode As ColumnSortMode = DirectCast(node("SortOn"), ColumnSortMode)
				Dim sortOrder As ColumnSortOrder = DirectCast(node("SortOrder"), ColumnSortOrder)
				column.SortMode = sortMode
				column.SortOrder = sortOrder
			Next node
			view.EndSort()
		End Sub

		Private Sub OnColumnChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemComboBox1.EditValueChanged
			Dim edit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			Dim val As Object = edit.EditValue
			If repositoryItemComboBox1.Items.Contains(val) Then
				repositoryItemComboBox1.Items.Remove(val)
			End If
		End Sub

		Private Sub OnMoveUp(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton5.Click
			Dim index As Integer = sortTree.GetNodeIndex(sortTree.FocusedNode)
			Dim prevIndex As Integer = index - 1
			If prevIndex = -1 Then
				Return
			End If
			sortTree.SetNodeIndex(sortTree.FocusedNode, prevIndex)
		End Sub

		Private Sub OnMoveDown(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton6.Click
			Dim index As Integer = sortTree.GetNodeIndex(sortTree.FocusedNode)
			Dim nextIndex As Integer = index + 1
			If nextIndex = sortTree.Nodes.Count Then
				Return
			End If
			sortTree.SetNodeIndex(sortTree.FocusedNode, nextIndex)
		End Sub
	End Class
End Namespace