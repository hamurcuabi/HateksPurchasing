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
    public partial class AddOrUpdateOfferingDialog : DevExpress.XtraEditors.XtraForm
    {
        private bool isNew = true;
        private OfferingRow row;
        public AddOrUpdateOfferingDialog()
        {
            InitializeComponent();
        }

        private void AddOrUpdateOfferingDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.hateksPurchasingDataSet.Currency);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.OfferingCompany' table. You can move, or remove it, as needed.
            this.offeringCompanyTableAdapter.Fill(this.hateksPurchasingDataSet.OfferingCompany);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewDraft' table. You can move, or remove it, as needed.
            this.viewDraftTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraft);

        }
     
       
        public AddOrUpdateOfferingDialog(int id)
        {
            InitializeComponent();
            row = offeringTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            lookupCurrency.EditValue = row.CurrencyId;
            lookupCompany.EditValue = row.OfferingCompanyId;
            lookupDraft.EditValue = row.DraftId;
            edtDescp.Text = row.Description;
            edtPrice.Text = row.Price.ToString();
            edtRate.Text = row.CurrencyRate.ToString();
            isNew = false;
        }
    

        private void btnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (isNew)
                {
                    offeringTableAdapter1.Insert(Int32.Parse(lookupDraft.EditValue.ToString()), Int32.Parse(lookupCompany.EditValue.ToString()), edtDescp.Text, DateTime.Now, double.Parse(edtPrice.Text), Int32.Parse(lookupCurrency.EditValue.ToString()), double.Parse(edtRate.Text.Replace(".", ",")));


                }
                else
                {
                    row.DraftId = Int32.Parse(lookupDraft.EditValue.ToString());
                    row.OfferingCompanyId = Int32.Parse(lookupCompany.EditValue.ToString());
                    row.CurrencyId = Int32.Parse(lookupCurrency.EditValue.ToString());
                    row.CurrencyRate = double.Parse(edtRate.Text.Replace(".",","));
                    row.Price = double.Parse(edtPrice.Text);
                    row.Description = edtDescp.Text;
                    offeringTableAdapter1.Update(row);


                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validate()
        {

            if (lookupDraft.GetSelectedDataRow() == null)
            {
                lookupDraft.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (lookupCompany.GetSelectedDataRow() == null)
            {
                lookupCompany.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (lookupCurrency.GetSelectedDataRow() == null)
            {
                lookupCurrency.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (String.IsNullOrEmpty(edtRate.Text))
            {
                edtRate.ErrorText = "Miktar Belirtiiz";
                return false;
            }
            else if (String.IsNullOrEmpty(edtPrice.Text))
            {
                edtPrice.ErrorText = "Açıklama Giriniz";
                return false;
            }
            else if (String.IsNullOrEmpty(edtDescp.Text))
            {
                edtDescp.ErrorText = "Açıklama Giriniz";
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