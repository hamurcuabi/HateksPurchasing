namespace HateksPurchasing
{
    partial class AddOrUpdateOfferingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateOfferingDialog));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookupDraft = new DevExpress.XtraEditors.GridLookUpEdit();
            this.viewDraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hateksPurchasingDataSet = new HateksPurchasing.HateksPurchasingDataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookupCompany = new DevExpress.XtraEditors.GridLookUpEdit();
            this.offeringCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookupCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.edtRate = new DevExpress.XtraEditors.TextEdit();
            this.edtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new DevExpress.XtraEditors.CheckButton();
            this.btnDone = new DevExpress.XtraEditors.CheckButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.edtDescp = new DevExpress.XtraEditors.MemoEdit();
            this.viewDraftTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.ViewDraftTableAdapter();
            this.offeringCompanyTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.OfferingCompanyTableAdapter();
            this.currencyTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.CurrencyTableAdapter();
            this.offeringTableAdapter1 = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.OfferingTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calDraftTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offeringCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPrice.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDescp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 28);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Satın Alma Formu:";
            // 
            // lookupDraft
            // 
            this.lookupDraft.EditValue = "";
            this.lookupDraft.Location = new System.Drawing.Point(216, 48);
            this.lookupDraft.Name = "lookupDraft";
            this.lookupDraft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupDraft.Properties.DataSource = this.viewDraftBindingSource;
            this.lookupDraft.Properties.DisplayMember = "Name";
            this.lookupDraft.Properties.PopupView = this.gridLookUpEdit1View;
            this.lookupDraft.Properties.ValueMember = "ID";
            this.lookupDraft.Size = new System.Drawing.Size(277, 22);
            this.lookupDraft.TabIndex = 21;
            // 
            // viewDraftBindingSource
            // 
            this.viewDraftBindingSource.DataMember = "ViewDraft";
            this.viewDraftBindingSource.DataSource = this.hateksPurchasingDataSet;
            // 
            // hateksPurchasingDataSet
            // 
            this.hateksPurchasingDataSet.DataSetName = "HateksPurchasingDataSet";
            this.hateksPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDraftId,
            this.calDraftTypeName,
            this.calUnit,
            this.calAmount,
            this.calDescription});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 28);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Tedarikçi:";
            // 
            // lookupCompany
            // 
            this.lookupCompany.EditValue = "";
            this.lookupCompany.Location = new System.Drawing.Point(216, 101);
            this.lookupCompany.Name = "lookupCompany";
            this.lookupCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCompany.Properties.DataSource = this.offeringCompanyBindingSource;
            this.lookupCompany.Properties.DisplayMember = "Name";
            this.lookupCompany.Properties.PopupView = this.gridView1;
            this.lookupCompany.Properties.ValueMember = "ID";
            this.lookupCompany.Size = new System.Drawing.Size(277, 22);
            this.lookupCompany.TabIndex = 23;
            // 
            // offeringCompanyBindingSource
            // 
            this.offeringCompanyBindingSource.DataMember = "OfferingCompany";
            this.offeringCompanyBindingSource.DataSource = this.hateksPurchasingDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(102, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 28);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Kur Cinsi:";
            // 
            // lookupCurrency
            // 
            this.lookupCurrency.EditValue = "";
            this.lookupCurrency.Location = new System.Drawing.Point(217, 160);
            this.lookupCurrency.Name = "lookupCurrency";
            this.lookupCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCurrency.Properties.DataSource = this.currencyBindingSource;
            this.lookupCurrency.Properties.DisplayMember = "Name";
            this.lookupCurrency.Properties.PopupView = this.gridView2;
            this.lookupCurrency.Properties.ValueMember = "ID";
            this.lookupCurrency.Size = new System.Drawing.Size(277, 22);
            this.lookupCurrency.TabIndex = 25;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.hateksPurchasingDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // edtRate
            // 
            this.edtRate.EditValue = "1";
            this.edtRate.Location = new System.Drawing.Point(216, 222);
            this.edtRate.Name = "edtRate";
            this.edtRate.Properties.Mask.EditMask = "f";
            this.edtRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edtRate.Size = new System.Drawing.Size(277, 22);
            this.edtRate.TabIndex = 27;
            // 
            // edtPrice
            // 
            this.edtPrice.Location = new System.Drawing.Point(217, 280);
            this.edtPrice.Name = "edtPrice";
            this.edtPrice.Properties.Mask.EditMask = "d";
            this.edtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edtPrice.Size = new System.Drawing.Size(277, 22);
            this.edtPrice.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(95, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 28);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Kur Oranı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 273);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(162, 28);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Birim Başı Fiyat:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDone, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 508);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 100);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(25);
            this.btnCancel.Size = new System.Drawing.Size(232, 80);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.CheckedChanged += new System.EventHandler(this.btnCancel_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone.ImageOptions.SvgImage")));
            this.btnDone.Location = new System.Drawing.Point(262, 10);
            this.btnDone.Margin = new System.Windows.Forms.Padding(10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Padding = new System.Windows.Forms.Padding(25);
            this.btnDone.Size = new System.Drawing.Size(233, 80);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "TAMAM";
            this.btnDone.CheckedChanged += new System.EventHandler(this.btnDone_CheckedChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(103, 328);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 28);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Açıklama:";
            // 
            // edtDescp
            // 
            this.edtDescp.EditValue = "-";
            this.edtDescp.Location = new System.Drawing.Point(216, 336);
            this.edtDescp.Name = "edtDescp";
            this.edtDescp.Size = new System.Drawing.Size(277, 124);
            this.edtDescp.TabIndex = 32;
            // 
            // viewDraftTableAdapter
            // 
            this.viewDraftTableAdapter.ClearBeforeFill = true;
            // 
            // offeringCompanyTableAdapter
            // 
            this.offeringCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // offeringTableAdapter1
            // 
            this.offeringTableAdapter1.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colDraftId
            // 
            this.colDraftId.Caption = "Satın Alma Formu";
            this.colDraftId.FieldName = "DraftId";
            this.colDraftId.Name = "colDraftId";
            this.colDraftId.Visible = true;
            this.colDraftId.VisibleIndex = 0;
            // 
            // calDraftTypeName
            // 
            this.calDraftTypeName.Caption = "Departman";
            this.calDraftTypeName.FieldName = "DraftTypeName";
            this.calDraftTypeName.Name = "calDraftTypeName";
            this.calDraftTypeName.Visible = true;
            this.calDraftTypeName.VisibleIndex = 1;
            // 
            // calUnit
            // 
            this.calUnit.Caption = "Birim";
            this.calUnit.FieldName = "UnitName";
            this.calUnit.Name = "calUnit";
            this.calUnit.Visible = true;
            this.calUnit.VisibleIndex = 2;
            // 
            // calAmount
            // 
            this.calAmount.Caption = "Miktar";
            this.calAmount.FieldName = "Amount";
            this.calAmount.Name = "calAmount";
            this.calAmount.Visible = true;
            this.calAmount.VisibleIndex = 3;
            // 
            // calDescription
            // 
            this.calDescription.Caption = "Açıklama";
            this.calDescription.FieldName = "Description";
            this.calDescription.Name = "calDescription";
            this.calDescription.Visible = true;
            this.calDescription.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ad";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Telefon";
            this.gridColumn3.FieldName = "Phone";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Email";
            this.gridColumn4.FieldName = "Email";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cinsi";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Simge";
            this.gridColumn7.FieldName = "ShortCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // AddOrUpdateOfferingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 608);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.edtPrice);
            this.Controls.Add(this.edtRate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookupCurrency);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookupCompany);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookupDraft);
            this.Controls.Add(this.edtDescp);
            this.Name = "AddOrUpdateOfferingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teklif Ekle-Güncelle";
            this.Load += new System.EventHandler(this.AddOrUpdateOfferingDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupDraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offeringCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPrice.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtDescp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit lookupDraft;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit lookupCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit lookupCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit edtRate;
        private DevExpress.XtraEditors.TextEdit edtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.CheckButton btnCancel;
        private DevExpress.XtraEditors.CheckButton btnDone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit edtDescp;
        private HateksPurchasingDataSet hateksPurchasingDataSet;
        private System.Windows.Forms.BindingSource viewDraftBindingSource;
        private HateksPurchasingDataSetTableAdapters.ViewDraftTableAdapter viewDraftTableAdapter;
        private System.Windows.Forms.BindingSource offeringCompanyBindingSource;
        private HateksPurchasingDataSetTableAdapters.OfferingCompanyTableAdapter offeringCompanyTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private HateksPurchasingDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private HateksPurchasingDataSetTableAdapters.OfferingTableAdapter offeringTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftId;
        private DevExpress.XtraGrid.Columns.GridColumn calDraftTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn calUnit;
        private DevExpress.XtraGrid.Columns.GridColumn calAmount;
        private DevExpress.XtraGrid.Columns.GridColumn calDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}