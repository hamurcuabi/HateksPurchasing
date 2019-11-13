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
using HateksPurchasing.Helper;
using static HateksPurchasing.HateksPurchasingDataSet;

namespace HateksPurchasing
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //validate
            if (Validate())
            {
                this.memberTableAdapter1.Fill(this.hateksPurchasingDataSet1.Member);
                object dt = this.hateksPurchasingDataSet1.Member.SingleOrDefault(p => p.UserName.ToLower() == txtUsername.Text.ToLower() && p.Password.ToLower() == txtPass.Text.ToLower());


                if (dt == null)
                {
                    XtraMessageBox.Show("Giriş Hatalı", "Hatalı", MessageBoxButtons.OK);
                }
                else
                {
                    SessionHelper.member =(MemberRow) dt;
                    DialogResult = DialogResult.OK;
                    Close();
                }

            }
        }

        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            return true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}