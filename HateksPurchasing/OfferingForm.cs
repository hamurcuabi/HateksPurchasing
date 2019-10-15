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
    public partial class OfferingForm : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public OfferingForm()
        {
            InitializeComponent();
        }

        private void OfferingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewOffering' table. You can move, or remove it, as needed.
            this.viewOfferingTableAdapter.Fill(this.hateksPurchasingDataSet.ViewOffering);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
                GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateOfferingDialog dialog = new AddOrUpdateOfferingDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.viewOfferingTableAdapter.ClearBeforeFill = true;
                this.viewOfferingTableAdapter.Fill(this.hateksPurchasingDataSet.ViewOffering);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateOfferingDialog dialog = new AddOrUpdateOfferingDialog(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.viewOfferingTableAdapter.ClearBeforeFill = true;
                    this.viewOfferingTableAdapter.Fill(this.hateksPurchasingDataSet.ViewOffering);
                }
            }
            else
            {

                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Seçim Yapınız", "Uyarı", MessageBoxButtons.OK);
            }

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