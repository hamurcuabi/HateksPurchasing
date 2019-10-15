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
    public partial class Currencies : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public Currencies()
        {
            InitializeComponent();
        }

        private void Currencies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.hateksPurchasingDataSet.Currency);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

      
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("ID");

            if (cell != null)
            {
                id = Int32.Parse(cell.ToString());
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddOrUpdateCurrrenciesDialog dialog = new AddOrUpdateCurrrenciesDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.currencyTableAdapter.ClearBeforeFill = true;
                this.currencyTableAdapter.Fill(this.hateksPurchasingDataSet.Currency);
            }

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateCurrrenciesDialog dialog = new AddOrUpdateCurrrenciesDialog(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.currencyTableAdapter.ClearBeforeFill = true;
                    this.currencyTableAdapter.Fill(this.hateksPurchasingDataSet.Currency);
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
    }
}