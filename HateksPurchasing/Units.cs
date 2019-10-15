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
    public partial class Units : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public Units()
        {
            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateUnitsDialog dialog = new AddOrUpdateUnitsDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.unitTableAdapter.ClearBeforeFill = true;
                this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateUnitsDialog dialog = new AddOrUpdateUnitsDialog(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.unitTableAdapter.ClearBeforeFill = true;
                    this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);
                }
            }
            else
            {

                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Seçim Yapınız", "Uyarı", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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