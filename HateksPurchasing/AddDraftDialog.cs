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
        private bool isNew = true;
        private DraftRow row;
        public AddDraftDialog()
        {
            InitializeComponent();
        }
        public AddDraftDialog(int id)
        {
            InitializeComponent();
            row = draftTableAdapter1.GetData().FirstOrDefault(p => p.ID == id);
            lookupDraftType.EditValue = row.DraftTypeId;
            lookupState.EditValue = row.StateId;
            lookupUnit.EditValue = row.UnitId;
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
            this.viewOfferingTableAdapter.Fill(this.hateksPurchasingDataSet.ViewOffering);
            DataTable dt = this.hateksPurchasingDataSet.ViewOffering;
            DataRow[] dr = dt.Select("DraftId= " + id);

            lookupOffers.Properties.View.BestFitColumns();
            lookupOffers.Properties.DisplayMember = "Name";
            lookupOffers.Properties.ValueMember = "ID";
            lookupOffers.Properties.DataSource = dr;

        }

        private void AddDraftDialog_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.State' table. You can move, or remove it, as needed.
            this.stateTableAdapter.Fill(this.hateksPurchasingDataSet.State);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.hateksPurchasingDataSet.Unit);
            // TODO: This line of code loads data into the 'hateksPurchasingDataSet.DraftType' table. You can move, or remove it, as needed.
            this.draftTypeTableAdapter.Fill(this.hateksPurchasingDataSet.DraftType);







        }

        private void btnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (isNew)
                {
                    draftTableAdapter1.Insert(Int32.Parse(lookupDraftType.EditValue.ToString()), Int32.Parse(lookupUnit.EditValue.ToString()), SessionHelper.member.ID, double.Parse(txtAmount.Text), txtDescp.Text, null, null, null, null, DateTime.Now, Int32.Parse(lookupState.EditValue.ToString()), null);


                }
                else
                {
                    row.DraftTypeId = Int32.Parse(lookupDraftType.EditValue.ToString());
                    row.StateId = Int32.Parse(lookupState.EditValue.ToString());
                    row.UnitId = Int32.Parse(lookupUnit.EditValue.ToString());
                    if (!String.IsNullOrEmpty(lookupOffers.EditValue.ToString()))
                    {
                        row.SelectedOffering = Int32.Parse(lookupOffers.EditValue.ToString());
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

            return true;
        }

        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}