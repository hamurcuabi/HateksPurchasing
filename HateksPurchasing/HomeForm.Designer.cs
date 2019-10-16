namespace HateksPurchasing
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCompanies = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurrencies = new DevExpress.XtraBars.BarButtonItem();
            this.btnDraftTypes = new DevExpress.XtraBars.BarButtonItem();
            this.btnStates = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnits = new DevExpress.XtraBars.BarButtonItem();
            this.btnDrafts = new DevExpress.XtraBars.BarButtonItem();
            this.btnOfferings = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bar = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnChart = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnCompanies,
            this.btnCurrencies,
            this.btnDraftTypes,
            this.btnStates,
            this.btnUnits,
            this.btnDrafts,
            this.btnOfferings,
            this.skinRibbonGalleryBarItem1,
            this.bar,
            this.btnChart});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.bar);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1018, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnCompanies
            // 
            this.btnCompanies.Caption = "Tedarikçiler";
            this.btnCompanies.Hint = "Teklif verebilecek şirketler";
            this.btnCompanies.Id = 1;
            this.btnCompanies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompanies.ImageOptions.SvgImage")));
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompanies_ItemClick);
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.Caption = "Para Birimleri";
            this.btnCurrencies.Id = 2;
            this.btnCurrencies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCurrencies.ImageOptions.SvgImage")));
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCurrencies_ItemClick);
            // 
            // btnDraftTypes
            // 
            this.btnDraftTypes.Caption = "Departmanlar";
            this.btnDraftTypes.Id = 3;
            this.btnDraftTypes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDraftTypes.ImageOptions.SvgImage")));
            this.btnDraftTypes.Name = "btnDraftTypes";
            this.btnDraftTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDraftTypes_ItemClick);
            // 
            // btnStates
            // 
            this.btnStates.Caption = "Durumlar";
            this.btnStates.Id = 4;
            this.btnStates.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStates.ImageOptions.SvgImage")));
            this.btnStates.Name = "btnStates";
            this.btnStates.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStates_ItemClick);
            // 
            // btnUnits
            // 
            this.btnUnits.Caption = "Birimler";
            this.btnUnits.Id = 5;
            this.btnUnits.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUnits.ImageOptions.SvgImage")));
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnits_ItemClick);
            // 
            // btnDrafts
            // 
            this.btnDrafts.Caption = "Satın Alma";
            this.btnDrafts.Id = 6;
            this.btnDrafts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDrafts.ImageOptions.SvgImage")));
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDrafts_ItemClick);
            // 
            // btnOfferings
            // 
            this.btnOfferings.Caption = "Teklifler";
            this.btnOfferings.Id = 7;
            this.btnOfferings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOfferings.ImageOptions.SvgImage")));
            this.btnOfferings.Name = "btnOfferings";
            this.btnOfferings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOfferings_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 8;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bar
            // 
            this.bar.Id = 10;
            this.bar.Name = "bar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Anasayfa";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDrafts);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnOfferings);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Satın Alma İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompanies);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tedarikçiler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDraftTypes);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Departmanlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCurrencies);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUnits);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStates);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Birimler ve Durumlar";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tema";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 511);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1018, 37);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnChart);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Tablolar";
            // 
            // btnChart
            // 
            this.btnChart.Caption = "Departman Harcamaları";
            this.btnChart.Id = 11;
            this.btnChart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnChart.Name = "btnChart";
            this.btnChart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChart_ItemClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 548);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hateks Satın Alma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Shown += new System.EventHandler(this.HomeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCompanies;
        private DevExpress.XtraBars.BarButtonItem btnCurrencies;
        private DevExpress.XtraBars.BarButtonItem btnDraftTypes;
        private DevExpress.XtraBars.BarButtonItem btnStates;
        private DevExpress.XtraBars.BarButtonItem btnUnits;
        private DevExpress.XtraBars.BarButtonItem btnDrafts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnOfferings;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarStaticItem bar;
        private DevExpress.XtraBars.BarButtonItem btnChart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}