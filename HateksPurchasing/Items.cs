using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace HateksPurchasing
{
    public partial class Items : DevExpress.XtraEditors.XtraForm
    {
        public Items()
        {
            InitializeComponent();
        }

        private int id;
        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("Id");

            if (cell != null)
            {
                id = Int32.Parse(cell.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateItems dialog = new AddOrUpdateItems();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.itemsTableAdapter.ClearBeforeFill = true;
                this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateItems dialog = new AddOrUpdateItems(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.itemsTableAdapter.ClearBeforeFill = true;
                    this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);
                }
            }
            else
            {

                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Seçim Yapınız", "Uyarı", MessageBoxButtons.OK);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.itemsTableAdapter.ClearBeforeFill = true;
            this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);
        }
    }
}