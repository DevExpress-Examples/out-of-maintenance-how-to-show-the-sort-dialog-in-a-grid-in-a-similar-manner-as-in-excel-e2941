using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraTreeList.Nodes;
using System.Collections;

namespace DXSample
{
    public partial class SortForm : DevExpress.XtraEditors.XtraForm
    {
        GridView view;
        public SortForm(GridView view)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.view = view;
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            SetUpRepositories();
            PopulateTree();
        }

        private void SetUpRepositories()
        {
            repositoryItemImageComboBox1.Items.AddEnum(typeof(ColumnSortOrder));
            repositoryItemImageComboBox2.Items.AddEnum(typeof(ColumnSortMode));
             
            ArrayList columns = new ArrayList();
            foreach (GridColumn col in view.VisibleColumns)
                if (col.SortIndex == -1)
                    columns.Add(col);
            repositoryItemComboBox1.Items.AddRange(columns);
        }

        private void PopulateTree()
        {
            foreach (GridColumn col in view.SortedColumns)
                sortTree.AppendNode(new object[] { col, col.SortMode, col.SortOrder }, null);
        }


        private void OnAddLevel(object sender, EventArgs e)
        {
            sortTree.AppendNode(new object[] {null, ColumnSortMode.Default, ColumnSortOrder.None}, null);
        }

        private void OnDeleteLevel(object sender, EventArgs e)
        {
            sortTree.DeleteNode(sortTree.FocusedNode);
        }

        public void SaveChanges()
        {
            view.BeginSort();
            view.ClearSorting();

            foreach (TreeListNode node in sortTree.Nodes)
            {
                GridColumn column = node["Column"] as GridColumn;
                if (column == null) continue;
                ColumnSortMode sortMode = (ColumnSortMode)node["SortOn"];
                ColumnSortOrder sortOrder = (ColumnSortOrder)node["SortOrder"];
                column.SortMode = sortMode;
                column.SortOrder = sortOrder;
            }
            view.EndSort();
        }

        private void OnColumnChanged(object sender, EventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
            object val = edit.EditValue;
            if(repositoryItemComboBox1.Items.Contains(val))
                repositoryItemComboBox1.Items.Remove(val);
        }

        private void OnMoveUp(object sender, EventArgs e)
        {
            int index = sortTree.GetNodeIndex(sortTree.FocusedNode);
            int prevIndex = index - 1;
            if (prevIndex == -1) return;
            sortTree.SetNodeIndex(sortTree.FocusedNode, prevIndex);
        }

        private void OnMoveDown(object sender, EventArgs e)
        {
            int index = sortTree.GetNodeIndex(sortTree.FocusedNode);
            int nextIndex = index + 1;
            if (nextIndex == sortTree.Nodes.Count) return;
            sortTree.SetNodeIndex(sortTree.FocusedNode, nextIndex);
        }
    }
}