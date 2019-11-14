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
using System.IO;
using DevExpress.XtraGrid.Columns;

namespace HateksPurchasing
{
    public partial class Exporting : DevExpress.XtraEditors.XtraForm
    {
        public Exporting()
        {
            InitializeComponent();
        }

        private void Exporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewDraftReport' table. You can move, or remove it, as needed.
            this.viewDraftReportTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraftReport);
         

        }

     

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            int[] s = gridView1.GetSelectedRows();

            gridView1.OptionsPrint.PrintSelectedRowsOnly = true;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excell|*.xlsx";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int[] s = gridView1.GetSelectedRows();

            gridView1.OptionsPrint.PrintSelectedRowsOnly = true;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pdf|*.pdf";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
               
                gridView1.ExportToPdf(save.FileName);
            }

        }
    }
}