namespace HateksPurchasing
{
    partial class Drafts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drafts));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewDraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hateksPurchasingDataSet = new HateksPurchasing.HateksPurchasingDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftFormNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedOffering = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfferingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfferingDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfferingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryToWarehouseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenerateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceNumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewDraftTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.ViewDraftTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.62264F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5849F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5849F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5849F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.62264F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 100);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(116, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(20);
            this.btnAdd.Size = new System.Drawing.Size(176, 94);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Yeni Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(298, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(20);
            this.btnEdit.Size = new System.Drawing.Size(176, 94);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(480, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(20);
            this.btnUpdate.Size = new System.Drawing.Size(176, 94);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Yenile";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewDraftBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(775, 416);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDraftId,
            this.colDraftTypeId,
            this.colDraftFormNo,
            this.colDraftTypeName,
            this.colName,
            this.colUnitName,
            this.colAmount,
            this.colDescription,
            this.colSelectedOffering,
            this.colCompanyId,
            this.colOfferingName,
            this.colPrice,
            this.colCurrencyRate,
            this.colCurrencyName,
            this.colShortCode,
            this.colOfferingDescription,
            this.colOfferingDate,
            this.colCompanyName,
            this.colStateName,
            this.colColor,
            this.colStateId,
            this.colBillDate,
            this.colReturnDate,
            this.colOrderDate,
            this.colDeliveryToWarehouseDate,
            this.colGenerateDate,
            this.colTotalPrice,
            this.colTotalPriceNumeric,
            this.colTotalPriceText,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colID.Width = 94;
            // 
            // colDraftId
            // 
            this.colDraftId.Caption = "Form No";
            this.colDraftId.FieldName = "DraftId";
            this.colDraftId.MinWidth = 25;
            this.colDraftId.Name = "colDraftId";
            this.colDraftId.Visible = true;
            this.colDraftId.VisibleIndex = 0;
            this.colDraftId.Width = 94;
            // 
            // colDraftTypeId
            // 
            this.colDraftTypeId.FieldName = "DraftTypeId";
            this.colDraftTypeId.MinWidth = 25;
            this.colDraftTypeId.Name = "colDraftTypeId";
            this.colDraftTypeId.Width = 94;
            // 
            // colDraftFormNo
            // 
            this.colDraftFormNo.Caption = "Departman Form No";
            this.colDraftFormNo.FieldName = "DraftFormNo";
            this.colDraftFormNo.MinWidth = 25;
            this.colDraftFormNo.Name = "colDraftFormNo";
            this.colDraftFormNo.Width = 94;
            // 
            // colDraftTypeName
            // 
            this.colDraftTypeName.Caption = "Departman";
            this.colDraftTypeName.FieldName = "DraftTypeName";
            this.colDraftTypeName.MinWidth = 25;
            this.colDraftTypeName.Name = "colDraftTypeName";
            this.colDraftTypeName.Visible = true;
            this.colDraftTypeName.VisibleIndex = 1;
            this.colDraftTypeName.Width = 94;
            // 
            // colName
            // 
            this.colName.Caption = "Kullanıcı";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 94;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Birim";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.MinWidth = 25;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 3;
            this.colUnitName.Width = 94;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Miktar";
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 94;
            // 
            // colSelectedOffering
            // 
            this.colSelectedOffering.Caption = "Seçili Teklif";
            this.colSelectedOffering.FieldName = "SelectedOffering";
            this.colSelectedOffering.MinWidth = 25;
            this.colSelectedOffering.Name = "colSelectedOffering";
            this.colSelectedOffering.Width = 94;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.MinWidth = 25;
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Width = 94;
            // 
            // colOfferingName
            // 
            this.colOfferingName.Caption = "Tedarikçi";
            this.colOfferingName.FieldName = "OfferingName";
            this.colOfferingName.MinWidth = 25;
            this.colOfferingName.Name = "colOfferingName";
            this.colOfferingName.Visible = true;
            this.colOfferingName.VisibleIndex = 7;
            this.colOfferingName.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Birim Fiyatı";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 8;
            this.colPrice.Width = 94;
            // 
            // colCurrencyRate
            // 
            this.colCurrencyRate.Caption = "Kur Oranı";
            this.colCurrencyRate.FieldName = "CurrencyRate";
            this.colCurrencyRate.MinWidth = 25;
            this.colCurrencyRate.Name = "colCurrencyRate";
            this.colCurrencyRate.Visible = true;
            this.colCurrencyRate.VisibleIndex = 9;
            this.colCurrencyRate.Width = 94;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Caption = "Kur Cinsi";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.MinWidth = 25;
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 10;
            this.colCurrencyName.Width = 94;
            // 
            // colShortCode
            // 
            this.colShortCode.FieldName = "ShortCode";
            this.colShortCode.MinWidth = 25;
            this.colShortCode.Name = "colShortCode";
            this.colShortCode.Width = 94;
            // 
            // colOfferingDescription
            // 
            this.colOfferingDescription.Caption = "Teklif Açıklaması";
            this.colOfferingDescription.FieldName = "OfferingDescription";
            this.colOfferingDescription.MinWidth = 25;
            this.colOfferingDescription.Name = "colOfferingDescription";
            this.colOfferingDescription.Visible = true;
            this.colOfferingDescription.VisibleIndex = 11;
            this.colOfferingDescription.Width = 94;
            // 
            // colOfferingDate
            // 
            this.colOfferingDate.Caption = "Teklif Tarihi";
            this.colOfferingDate.FieldName = "OfferingDate";
            this.colOfferingDate.MinWidth = 25;
            this.colOfferingDate.Name = "colOfferingDate";
            this.colOfferingDate.Visible = true;
            this.colOfferingDate.VisibleIndex = 12;
            this.colOfferingDate.Width = 94;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 25;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Width = 94;
            // 
            // colStateName
            // 
            this.colStateName.Caption = "Durum";
            this.colStateName.FieldName = "StateName";
            this.colStateName.MinWidth = 25;
            this.colStateName.Name = "colStateName";
            this.colStateName.Visible = true;
            this.colStateName.VisibleIndex = 13;
            this.colStateName.Width = 94;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.MinWidth = 25;
            this.colColor.Name = "colColor";
            this.colColor.Width = 94;
            // 
            // colStateId
            // 
            this.colStateId.FieldName = "StateId";
            this.colStateId.MinWidth = 25;
            this.colStateId.Name = "colStateId";
            this.colStateId.Width = 94;
            // 
            // colBillDate
            // 
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.MinWidth = 25;
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.Width = 94;
            // 
            // colReturnDate
            // 
            this.colReturnDate.FieldName = "ReturnDate";
            this.colReturnDate.MinWidth = 25;
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Width = 94;
            // 
            // colDeliveryToWarehouseDate
            // 
            this.colDeliveryToWarehouseDate.FieldName = "DeliveryToWarehouseDate";
            this.colDeliveryToWarehouseDate.MinWidth = 25;
            this.colDeliveryToWarehouseDate.Name = "colDeliveryToWarehouseDate";
            this.colDeliveryToWarehouseDate.Width = 94;
            // 
            // colGenerateDate
            // 
            this.colGenerateDate.Caption = "Tarih";
            this.colGenerateDate.FieldName = "GenerateDate";
            this.colGenerateDate.MinWidth = 25;
            this.colGenerateDate.Name = "colGenerateDate";
            this.colGenerateDate.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Toplam Fiyat";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 14;
            this.colTotalPrice.Width = 94;
            // 
            // colTotalPriceNumeric
            // 
            this.colTotalPriceNumeric.FieldName = "TotalPriceNumeric";
            this.colTotalPriceNumeric.MinWidth = 25;
            this.colTotalPriceNumeric.Name = "colTotalPriceNumeric";
            this.colTotalPriceNumeric.Visible = true;
            this.colTotalPriceNumeric.VisibleIndex = 15;
            this.colTotalPriceNumeric.Width = 94;
            // 
            // colTotalPriceText
            // 
            this.colTotalPriceText.Caption = "Toplam Fiyat Hesap";
            this.colTotalPriceText.FieldName = "TotalPriceText";
            this.colTotalPriceText.MinWidth = 25;
            this.colTotalPriceText.Name = "colTotalPriceText";
            this.colTotalPriceText.Visible = true;
            this.colTotalPriceText.VisibleIndex = 16;
            this.colTotalPriceText.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Malzeme Cinsi";
            this.gridColumn1.FieldName = "ItemName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // viewDraftTableAdapter
            // 
            this.viewDraftTableAdapter.ClearBeforeFill = true;
            // 
            // Drafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Drafts";
            this.Text = "Satın Alma";
            this.Load += new System.EventHandler(this.Drafts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftId;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftFormNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedOffering;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colOfferingName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortCode;
        private DevExpress.XtraGrid.Columns.GridColumn colOfferingDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colOfferingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colStateName;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colStateId;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryToWarehouseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colGenerateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceNumeric;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private HateksPurchasingDataSet hateksPurchasingDataSet;
        private System.Windows.Forms.BindingSource viewDraftBindingSource;
        private HateksPurchasingDataSetTableAdapters.ViewDraftTableAdapter viewDraftTableAdapter;
    }
}