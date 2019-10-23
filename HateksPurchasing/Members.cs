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
    public partial class Members : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.hateksPurchasingDataSet.Member);

        }

     

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateMember dialog = new AddOrUpdateMember();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.memberTableAdapter.ClearBeforeFill = true;
                this.memberTableAdapter.Fill(this.hateksPurchasingDataSet.Member);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                AddOrUpdateMember dialog = new AddOrUpdateMember(id);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.memberTableAdapter.ClearBeforeFill = true;
                    this.memberTableAdapter.Fill(this.hateksPurchasingDataSet.Member);
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.memberTableAdapter.ClearBeforeFill = true;
            this.memberTableAdapter.Fill(this.hateksPurchasingDataSet.Member);
        }
    }
}