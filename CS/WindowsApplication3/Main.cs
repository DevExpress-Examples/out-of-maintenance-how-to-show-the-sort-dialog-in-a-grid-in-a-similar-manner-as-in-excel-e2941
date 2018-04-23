using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 5;i++) 
                dataSet11.Tables[0].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i,  DateTime.Today.AddDays(i), true });
            
        }
        SortDialogProvider provider;
        private void OnLoad(object sender, EventArgs e) {
            InitData();
            provider = new SortDialogProvider(gridView1);
            provider.EnableSortDialog();
           // provider.ShowSortIndexInColumnHeader 
        }

        private void OmFormClosing(object sender, FormClosingEventArgs e)
        {
            provider.DisableSortDialog();
        }
    }
}
