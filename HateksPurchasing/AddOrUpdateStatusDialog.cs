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
    public partial class AddOrUpdateStatusDialog : DevExpress.XtraEditors.XtraForm
    {
        private bool isNew = true;
        private StateRow state;
        public AddOrUpdateStatusDialog()
        {
            InitializeComponent();
        }
        public AddOrUpdateStatusDialog(int id)
        {

            InitializeComponent();
            state = stateTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            txtDescp.Text = state.Description;
            txtName.Text = state.Name;
            clrpick.Text = state.Color;
            isNew = false;
        }

        private void btnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (Validate())
            {
                DialogResult = DialogResult.OK;
                if (isNew)
                {
                    stateTableAdapter1.Insert(txtName.Text, clrpick.Text, txtDescp.Text);
                }
                else
                {
                    state.Name = txtName.Text;
                    state.Description = txtDescp.Text;
                    state.Color = clrpick.Text;
                    stateTableAdapter1.Update(state);
                }


                Close();
            }

        }
        private bool Validate()
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtDescp.Text))
            {
                txtDescp.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            else if (String.IsNullOrEmpty(clrpick.Text))
            {
                clrpick.ErrorText = "Boş Bırakılamaz";
                return false;
            }
            return true;


        }
        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
    }
}