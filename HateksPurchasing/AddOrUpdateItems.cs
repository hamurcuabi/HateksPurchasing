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
    public partial class AddOrUpdateItems : DevExpress.XtraEditors.XtraForm
    {
        public AddOrUpdateItems()
        {
            InitializeComponent();
        }

        private bool isNew = true;
        private ItemsRow row;
     
        public AddOrUpdateItems(int id)
        {
            InitializeComponent();
            row = itemsTableAdapter1.GetData().FirstOrDefault(p => p.Id == id);
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
                    itemsTableAdapter1.Insert(txtName.Text);
                }
                else
                {
                    row.Name = txtName.Text;
                    itemsTableAdapter1.Update(row);
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