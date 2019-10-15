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
using static HateksPurchasing.HateksPurchasingDataSet;

namespace HateksPurchasing
{
    public partial class AddOrUpdateDraftTypesDialod : DevExpress.XtraEditors.XtraForm
    {
        public AddOrUpdateDraftTypesDialod()
        {
            InitializeComponent();
        }

        private bool isNew = true;
        private DraftTypeRow row;
        public AddOrUpdateDraftTypesDialod(int id)
        {
            InitializeComponent();
            row = draftTypeTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            txtName.Text = row.Name;
            isNew = false;
        }
        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.ErrorText = "Boş Bırakılamaz";
                return false;
            }

            return true;


        }
        private void btnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (Validate())
            {
                DialogResult = DialogResult.OK;
                if (isNew)
                {
                    draftTypeTableAdapter1.Insert(txtName.Text, DateTime.Now);
                }
                else
                {
                    row.Name = txtName.Text;
                    draftTypeTableAdapter1.Update(row);
                }


                Close();
            }

        }
        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}