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

namespace HateksPurchasing
{
    public partial class Drafts : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public Drafts()
        {
            InitializeComponent();
        }

        private void Drafts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewDraft' table. You can move, or remove it, as needed.
            this.viewDraftTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraft);

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "StateName")
            {
                String color = view.GetRowCellValue(e.RowHandle, "Color").ToString();
                e.Appearance.BackColor = ColorHelper.ToColor(color);

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDraftDialog dialog = new AddDraftDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.viewDraftTableAdapter.ClearBeforeFill = true;
                this.viewDraftTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraft);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddDraftDialog dialog = new AddDraftDialog(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.viewDraftTableAdapter.ClearBeforeFill = true;
                    this.viewDraftTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraft);
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
            if (cell != null) {
                id = Int32.Parse(cell.ToString());
            }
               
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}