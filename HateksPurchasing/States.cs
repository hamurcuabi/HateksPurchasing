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
using HateksPurchasing.Helper;
using static HateksPurchasing.HateksPurchasingDataSet;

namespace HateksPurchasing
{
    public partial class States : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public States()
        {
            InitializeComponent();
        }

        private void States_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.State' table. You can move, or remove it, as needed.
            this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateStatusDialog dialog = new AddOrUpdateStatusDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.stateTableAdapter.ClearBeforeFill = true;
                this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateStatusDialog dialog = new AddOrUpdateStatusDialog(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.stateTableAdapter.ClearBeforeFill = true;
                    this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);
                }
            }
            else {

                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Seçim Yapınız", "Uyarı", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("ID");

            id = Int32.Parse(cell.ToString());

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("ID");

            if (cell != null)
            {
                id = Int32.Parse(cell.ToString());
            }
        }
    }
}