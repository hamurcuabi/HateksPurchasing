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
    public partial class AddOrUpdateMember : DevExpress.XtraEditors.XtraForm
    {
        public AddOrUpdateMember()
        {
            InitializeComponent();
        }

        private bool isNew = true;
        private MemberRow row;

        public AddOrUpdateMember(int id)
        {
            InitializeComponent();
            row = memberTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            txtName.Text = row.Name;
            txtMail.Text = row.Email;
            txtPassword.Text = row.Password;
            txtSurname.Text = row.Surname;
            isNew = false;
        }
        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtSurname.Text))
            {
                txtSurname.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtMail.Text))
            {
                txtMail.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.ErrorText = "Boş Bırakılamaz";
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
                    memberTableAdapter1.Insert(txtName.Text, txtSurname.Text, txtMail.Text, txtPassword.Text, false, DateTime.Now);
                }
                else
                {
                    row.Name = txtName.Text;
                    row.Surname = txtSurname.Text;
                    row.Password = txtPassword.Text;
                    row.Email = txtMail.Text;
                    memberTableAdapter1.Update(row);
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