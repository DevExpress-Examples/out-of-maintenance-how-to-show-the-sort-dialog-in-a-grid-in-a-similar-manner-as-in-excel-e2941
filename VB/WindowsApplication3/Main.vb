Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 4
				dataSet11.Tables(0).Rows.Add(New Object() { i, String.Format("FirstName {0}", i), i, Date.Today.AddDays(i), True })
			Next i

		End Sub
		Private provider As SortDialogProvider
		Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			InitData()
			provider = New SortDialogProvider(gridView1)
			provider.EnableSortDialog()
		   ' provider.ShowSortIndexInColumnHeader 
		End Sub

		Private Sub OmFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
			provider.DisableSortDialog()
		End Sub
	End Class
End Namespace
