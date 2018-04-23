Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class SortForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SortForm))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.deleteLevelButton = New DevExpress.XtraEditors.SimpleButton()
			Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
			Me.addLevelButton = New DevExpress.XtraEditors.SimpleButton()
			Me.sortTree = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sortTree, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.AllowCustomizationMenu = False
			Me.layoutControl1.Controls.Add(Me.simpleButton6)
			Me.layoutControl1.Controls.Add(Me.simpleButton5)
			Me.layoutControl1.Controls.Add(Me.deleteLevelButton)
			Me.layoutControl1.Controls.Add(Me.addLevelButton)
			Me.layoutControl1.Controls.Add(Me.sortTree)
			Me.layoutControl1.Controls.Add(Me.simpleButton3)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(611, 99, 450, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(565, 282)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' simpleButton6
			' 
			Me.simpleButton6.Image = My.Resources.Down
			Me.simpleButton6.Location = New System.Drawing.Point(525, 12)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(28, 22)
			Me.simpleButton6.StyleController = Me.layoutControl1
			Me.simpleButton6.TabIndex = 11
'			Me.simpleButton6.Click += New System.EventHandler(Me.OnMoveDown);
			' 
			' simpleButton5
			' 
			Me.simpleButton5.Image = My.Resources.Up
			Me.simpleButton5.Location = New System.Drawing.Point(492, 12)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(29, 22)
			Me.simpleButton5.StyleController = Me.layoutControl1
			Me.simpleButton5.TabIndex = 10
'			Me.simpleButton5.Click += New System.EventHandler(Me.OnMoveUp);
			' 
			' deleteLevelButton
			' 
			Me.deleteLevelButton.ImageIndex = 1
			Me.deleteLevelButton.ImageList = Me.imageCollection
			Me.deleteLevelButton.Location = New System.Drawing.Point(379, 12)
			Me.deleteLevelButton.Name = "deleteLevelButton"
			Me.deleteLevelButton.Size = New System.Drawing.Size(109, 22)
			Me.deleteLevelButton.StyleController = Me.layoutControl1
			Me.deleteLevelButton.TabIndex = 9
			Me.deleteLevelButton.Text = "DeleteLevel"
'			Me.deleteLevelButton.Click += New System.EventHandler(Me.OnDeleteLevel);
			' 
			' imageCollection
			' 
			Me.imageCollection.ImageStream = (CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' addLevelButton
			' 
			Me.addLevelButton.ImageIndex = 0
			Me.addLevelButton.ImageList = Me.imageCollection
			Me.addLevelButton.Location = New System.Drawing.Point(266, 12)
			Me.addLevelButton.Name = "addLevelButton"
			Me.addLevelButton.Size = New System.Drawing.Size(109, 22)
			Me.addLevelButton.StyleController = Me.layoutControl1
			Me.addLevelButton.TabIndex = 8
			Me.addLevelButton.Text = "AddLevel"
'			Me.addLevelButton.Click += New System.EventHandler(Me.OnAddLevel);
			' 
			' sortTree
			' 
			Me.sortTree.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3})
			Me.sortTree.Location = New System.Drawing.Point(12, 38)
			Me.sortTree.Name = "sortTree"
			Me.sortTree.OptionsView.ShowIndicator = False
			Me.sortTree.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
			Me.sortTree.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
			Me.sortTree.Size = New System.Drawing.Size(541, 206)
			Me.sortTree.TabIndex = 7
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Column"
			Me.treeListColumn1.ColumnEdit = Me.repositoryItemComboBox1
			Me.treeListColumn1.FieldName = "Column"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.OptionsColumn.AllowMoveToCustomizationForm = False
			Me.treeListColumn1.OptionsColumn.AllowSort = False
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
'			Me.repositoryItemComboBox1.EditValueChanged += New System.EventHandler(Me.OnColumnChanged);
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "SortOn"
			Me.treeListColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
			Me.treeListColumn2.FieldName = "SortOn"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.OptionsColumn.AllowMoveToCustomizationForm = False
			Me.treeListColumn2.OptionsColumn.AllowSort = False
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "SortOrder"
			Me.treeListColumn3.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.treeListColumn3.FieldName = "SortOrder"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.OptionsColumn.AllowMoveToCustomizationForm = False
			Me.treeListColumn3.OptionsColumn.AllowSort = False
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 2
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			' 
			' simpleButton3
			' 
			Me.simpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.simpleButton3.Location = New System.Drawing.Point(471, 248)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(82, 22)
			Me.simpleButton3.StyleController = Me.layoutControl1
			Me.simpleButton3.TabIndex = 6
			Me.simpleButton3.Text = "Cancel"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(387, 248)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(80, 22)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Ok"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Root"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.emptySpaceItem1, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(565, 282)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.simpleButton3
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(459, 236)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(86, 26)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 236)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(375, 26)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.simpleButton1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(375, 236)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(84, 26)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.sortTree
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 26)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(545, 210)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.addLevelButton
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(254, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(113, 26)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.deleteLevelButton
			Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
			Me.layoutControlItem8.Location = New System.Drawing.Point(367, 0)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(113, 26)
			Me.layoutControlItem8.Text = "layoutControlItem8"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextToControlDistance = 0
			Me.layoutControlItem8.TextVisible = False
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.simpleButton5
			Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
			Me.layoutControlItem9.Location = New System.Drawing.Point(480, 0)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(33, 26)
			Me.layoutControlItem9.Text = "layoutControlItem9"
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem9.TextToControlDistance = 0
			Me.layoutControlItem9.TextVisible = False
			' 
			' layoutControlItem10
			' 
			Me.layoutControlItem10.Control = Me.simpleButton6
			Me.layoutControlItem10.CustomizationFormText = "layoutControlItem10"
			Me.layoutControlItem10.Location = New System.Drawing.Point(513, 0)
			Me.layoutControlItem10.Name = "layoutControlItem10"
			Me.layoutControlItem10.Size = New System.Drawing.Size(32, 26)
			Me.layoutControlItem10.Text = "layoutControlItem10"
			Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem10.TextToControlDistance = 0
			Me.layoutControlItem10.TextVisible = False
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 0)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(254, 26)
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.addLevelButton
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem5.Name = "layoutControlItem4"
			Me.layoutControlItem5.Size = New System.Drawing.Size(540, 26)
			Me.layoutControlItem5.Text = "layoutControlItem4"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.addLevelButton
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem6.Name = "layoutControlItem4"
			Me.layoutControlItem6.Size = New System.Drawing.Size(540, 26)
			Me.layoutControlItem6.Text = "layoutControlItem4"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.addLevelButton
			Me.layoutControlItem7.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem7.Name = "layoutControlItem4"
			Me.layoutControlItem7.Size = New System.Drawing.Size(540, 26)
			Me.layoutControlItem7.Text = "layoutControlItem4"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextToControlDistance = 0
			Me.layoutControlItem7.TextVisible = False
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 233)
			Me.emptySpaceItem2.Name = "emptySpaceItem1"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(391, 26)
			Me.emptySpaceItem2.Text = "emptySpaceItem1"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' SortForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(565, 282)
			Me.Controls.Add(Me.layoutControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SortForm"
			Me.ShowIcon = False
			Me.Text = "SortForm"
'			Me.Load += New System.EventHandler(Me.SortForm_Load);
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sortTree, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private sortTree As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents deleteLevelButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents addLevelButton As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private WithEvents repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection As DevExpress.Utils.ImageCollection
	End Class
End Namespace