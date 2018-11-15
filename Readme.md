<!-- default file list -->
*Files to look at*:

* [DataSet1.cs](./CS/WindowsApplication3/DataSet1.cs) (VB: [DataSet1.vb](./VB/WindowsApplication3/DataSet1.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
* [SortDialogProvider.cs](./CS/WindowsApplication3/SortDialogProvider.cs) (VB: [SortDialogProvider.vb](./VB/WindowsApplication3/SortDialogProvider.vb))
* [SortForm.cs](./CS/WindowsApplication3/SortForm.cs) (VB: [SortForm.vb](./VB/WindowsApplication3/SortForm.vb))
<!-- default file list end -->
# How to show the Sort Dialog in a grid in a similar manner as in Excel


<p>This example illustrates how to provide an end-user with the Sort Dialog allowing him/her to customize  sorted columns. Also, it is possible to show sort indexes of the sorted columns in their column headers by setting the SortDialogProvider.ShowSortIndexInColumnHeader property to true. </p><p><strong>NOTE: </strong>If you are using version earlier than 10.2 handle the GridView.ShowGridMenu event rather than the  GridView.PopupMenuShowing event in the SortDialogProvider class. </p>

<br/>


