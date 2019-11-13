using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using HateksPurchasing.Helper;

namespace HateksPurchasing
{
    public partial class HomeForm : RibbonForm
    {

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnOfferings_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is OfferingForm)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new OfferingForm());
        }

        private void btnDrafts_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Drafts)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Drafts());
        }

        private void btnCompanies_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Companies)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Companies());
        }

        private void CreateMdiForm(DevExpress.XtraEditors.XtraForm form)
        {

            form.MdiParent = this;
            form.Show();
            form.BringToFront();

        }

        private void btnDraftTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is DraftTypes)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new DraftTypes());
        }

        private void btnCurrencies_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Currencies)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Currencies());

        }

        private void btnUnits_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Units)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Units());
        }

        private void btnStates_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is States)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new States());

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            if (new Login().ShowDialog() == DialogResult.OK)
            {
                bar.Caption = "Holgeldiniz " + SessionHelper.member.Name.ToUpper();
                CreateMdiForm(new Items());
            }


        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is DashBoard)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new DashBoard());
        }

        private void btnAddMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SessionHelper.member.Name.ToLower() == "admin")
            {
                bool isexist = false;

                foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
                {
                    if (form is Members)
                    {
                        form.BringToFront();
                        isexist = true;
                        break;

                    }
                }
                if (!isexist)
                    CreateMdiForm(new Members());
            }
            else {

                DevExpress.XtraEditors.XtraMessageBox.Show("Yetkiniz Bulunmuyor", "Uyarı", MessageBoxButtons.OK);


            }
        
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Items)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Items());
        }
    }


}