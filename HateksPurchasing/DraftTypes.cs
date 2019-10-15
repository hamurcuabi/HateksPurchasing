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
    public partial class DraftTypes : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public DraftTypes()
        {
            InitializeComponent();
        }

        private void DraftTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.DraftType' table. You can move, or remove it, as needed.
            this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateDraftTypesDialod dialog = new AddOrUpdateDraftTypesDialod();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.draftTypeTableAdapter.ClearBeforeFill = true;
                this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateDraftTypesDialod dialog = new AddOrUpdateDraftTypesDialod(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.draftTypeTableAdapter.ClearBeforeFill = true;
                    this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);
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