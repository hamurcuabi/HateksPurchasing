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
    public partial class AddOrUpdateUnitsDialog : DevExpress.XtraEditors.XtraForm
    {

        private bool isNew = true;
        private UnitRow unit;
        public AddOrUpdateUnitsDialog(int id)
        {
            InitializeComponent();
            unit = unitTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);            
            txtName.Text = unit.Name;
            isNew = false;
        }
        public AddOrUpdateUnitsDialog()
        {
            InitializeComponent();
         
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
                    unitTableAdapter1.Insert(txtName.Text,DateTime.Now);
                }
                else
                {
                    unit.Name = txtName.Text;
                    unitTableAdapter1.Update(unit);
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