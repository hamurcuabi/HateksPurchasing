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
    public partial class AddOrUpdateCurrrenciesDialog : DevExpress.XtraEditors.XtraForm
    {
        private bool isNew = true;
        private CurrencyRow row;
        public AddOrUpdateCurrrenciesDialog()
        {
            InitializeComponent();
        }
        public AddOrUpdateCurrrenciesDialog(int id)
        {
            InitializeComponent();
            row = currencyTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            txtName.Text = row.Name;
            txtShortCode.Text = row.ShortCode;
            isNew = false;
        }
        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtShortCode.Text))
            {
                txtShortCode.ErrorText = "Boş Bırakılamaz";
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
                    currencyTableAdapter1.Insert(txtName.Text, txtShortCode.Text, DateTime.Now);
                }
                else
                {
                    row.Name = txtName.Text;
                    row.ShortCode = txtShortCode.Text;
                    currencyTableAdapter1.Update(row);
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