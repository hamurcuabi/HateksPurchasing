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
using HateksPurchasing.Helper;

namespace HateksPurchasing
{
    public partial class AddDraftDialog : DevExpress.XtraEditors.XtraForm
    {
        public AddDraftDialog()
        {
            InitializeComponent();
        }

        private bool isNew = true;
        private DraftRow row;

        public AddDraftDialog(int id)
        {
            InitializeComponent();
            row = draftTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            lookupDraftType.EditValue = row.DraftTypeId;
            lookupState.EditValue = row.StateId;
            lookupUnit.EditValue = row.UnitId;
            lookUpItem.EditValue = row.ItemId;

            lookupDraftType.Enabled = false;
            lookUpItem.Enabled = false;
            try
            {
                lookupOffers.EditValue = row.SelectedOffering;
            }
            catch (Exception)
            {
            }

            txtAmount.Text = row.Amount.ToString();
            txtDescp.Text = row.Description;
            isNew = false;
            FillOffers(id);

        }

        private void FillOffers(int id)
        {
       this.viewOfferingTableAdapter.FillByDraftId(this.hateksPurchasingDataSet.ViewOffering, id);


        }

        private void AddDraftDialog_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);
            this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);
            this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);
            this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);


        }

        private void btnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (isNew)
                {
                    int draftType = Int32.Parse(lookupDraftType.EditValue.ToString());
                    int unitId = Int32.Parse(lookupUnit.EditValue.ToString());
                    int itemId = Int32.Parse(lookUpItem.EditValue.ToString());
                    draftTableAdapter1.Insert(draftType, unitId, itemId, SessionHelper.member.ID,
double.Parse(txtAmount.Text), txtDescp.Text, null, null, null, null, DateTime.Now, Int32.Parse(lookupState.EditValue.ToString()), null);


                }
                else
                {
                    row.DraftTypeId = Int32.Parse(lookupDraftType.EditValue.ToString());
                    row.StateId = Int32.Parse(lookupState.EditValue.ToString());
                    row.UnitId = Int32.Parse(lookupUnit.EditValue.ToString());
                    if (lookupOffers.EditValue != null)
                    {
                        if (!String.IsNullOrEmpty(lookupOffers.EditValue.ToString()))
                        {
                            row.SelectedOffering = Int32.Parse(lookupOffers.EditValue.ToString());
                        }
                    }
                 

                    row.Amount = double.Parse(txtAmount.Text);
                    row.Description = txtDescp.Text;
                    draftTableAdapter1.Update(row);


                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validate()
        {

            if (lookupDraftType.GetSelectedDataRow() == null)
            {
                lookupDraftType.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (lookupUnit.GetSelectedDataRow() == null)
            {
                lookupUnit.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (String.IsNullOrEmpty(txtAmount.Text))
            {
                txtAmount.ErrorText = "Miktar Belirtiiz";
                return false;
            }
            else if (String.IsNullOrEmpty(txtDescp.Text))
            {
                txtDescp.ErrorText = "Açıklama Giriniz";
                return false;
            }
            else if (lookupState.GetSelectedDataRow() == null)
            {
                lookupState.ErrorText = "Seçim Yapınız";
                return false;
            }
            else if (lookUpItem.GetSelectedDataRow() == null)
            {
                lookupState.ErrorText = "Seçim Yapınız";
                return false;
            }

            return true;
        }

        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddDraftDialog_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewDraft' table. You can move, or remove it, as needed.
            this.viewDraftTableAdapter.Fill(this.hateksPurchasingDataSet.ViewDraft);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewOffering' table. You can move, or remove it, as needed.
         
            this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.ViewOffering' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.hateksPurchasingDataSet.Items);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.DraftType' table. You can move, or remove it, as needed.
            this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);

        }
    }
}