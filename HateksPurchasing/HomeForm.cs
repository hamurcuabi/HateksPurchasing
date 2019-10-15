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
           
            CreateMdiForm(new Drafts());
            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK) {
               
            }
           
            
        }
    }


}