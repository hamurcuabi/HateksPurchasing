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
    public partial class AddOrUpdateCompaniesDialog : DevExpress.XtraEditors.XtraForm
    {
        public AddOrUpdateCompaniesDialog()
        {
            InitializeComponent();
        }

        private bool isNew = true;
        private OfferingCompanyRow row;

        public AddOrUpdateCompaniesDialog(int id)
        {
            InitializeComponent();
            row = offeringCompanyTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            txtName.Text = row.Name;
            txtMail.Text = row.Email;
            txtPhone.Text = row.Phone;
            isNew = false;
        }
        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtMail.Text))
            {
                txtMail.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.ErrorText = "Boş Bırakılamaz";
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
                    offeringCompanyTableAdapter1.Insert(txtName.Text, txtPhone.Text, txtMail.Text, DateTime.Now);
                }
                else
                {
                    row.Name = txtName.Text;
                    row.Email = txtMail.Text;
                    row.Phone = txtPhone.Text;
                    row.Date = DateTime.Now;
                    offeringCompanyTableAdapter1.Update(row);
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