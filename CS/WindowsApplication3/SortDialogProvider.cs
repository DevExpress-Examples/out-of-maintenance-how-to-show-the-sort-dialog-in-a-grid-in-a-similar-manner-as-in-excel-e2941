using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using System.Windows.Forms;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.XtraGrid.Columns;
using WindowsApplication3.Properties;

namespace DXSample
{
     public class SortDialogProvider  {
         GridView view;
         bool showSortIndexInColumnHeader = true;
         public SortDialogProvider(GridView view)
         {
             this.view = view;
         }

         public void EnableSortDialog()
         {
             view.PopupMenuShowing += OnPopupMenuShowing;
             view.CustomDrawColumnHeader += OnCustomDrawColumnHeader;
         }

         public bool ShowSortIndexInColumnHeader
         {
             get { return showSortIndexInColumnHeader; }
             set
             {
                 if (showSortIndexInColumnHeader != value)
                 {
                     showSortIndexInColumnHeader = value;
                     foreach (GridColumn col in view.SortedColumns)
                         view.InvalidateColumnHeader(col);
                 }
             }
         }

         void OnCustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
         {
             if (!ShowSortIndexInColumnHeader || e.Column == null || e.Column.SortIndex == -1) return;
             GridColumnInfoArgs args = e.Info as GridColumnInfoArgs;
             e.Painter.DrawObject(args);
             SortedShapeObjectInfoArgs sortArgs = (SortedShapeObjectInfoArgs)args.InnerElements.Find(typeof(SortedShapeObjectInfoArgs)).ElementInfo;
             Rectangle sortRectangle = sortArgs.Bounds;
             Rectangle sortIndexRectangle = new Rectangle(sortRectangle.X - 8, args.CaptionRect.Y,
                 10, args.CaptionRect.Height);
             SolidBrush brush = e.Appearance.GetBackBrush(e.Cache) as SolidBrush;
             brush.Color = Color.FromArgb(150, brush.Color);
             Rectangle sortIndexShapeRectangle = new Rectangle(sortIndexRectangle.X - 2, sortIndexRectangle.Y,
             sortIndexRectangle.Width + sortRectangle.Width, sortIndexRectangle.Height);
             e.Cache.FillRectangle(brush, sortIndexShapeRectangle);
             e.Appearance.DrawString(e.Cache, e.Column.SortIndex.ToString(), sortIndexRectangle);
             e.Handled = true;
         }

         void OnPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
         {
             GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
             if (menu == null) return;
             menu.Items.Add(new DXMenuItem("Show Sort Dialog", OnItemClick, Resources.SortDialog));
         }

         void OnItemClick(object sender, EventArgs e) {
             using (SortForm f = new SortForm(view))
             {
                 if (f.ShowDialog() == DialogResult.OK)
                     f.SaveChanges();
             }
         }

         public void DisableSortDialog()
         {
             view.PopupMenuShowing -= OnPopupMenuShowing;
             view.CustomDrawColumnHeader -= OnCustomDrawColumnHeader;
         }
    }
}
