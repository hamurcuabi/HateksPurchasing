namespace HateksPurchasing
{
    partial class Exporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exporting));
            this.viewDraftReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hateksPurchasingDataSet = new HateksPurchasing.HateksPurchasingDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDraftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDraftTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenerateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.viewDraftReportTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.ViewDraftReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewDraftReportBindingSource
            // 
            this.viewDraftReportBindingSource.DataMember = "ViewDraftReport";
            this.viewDraftReportBindingSource.DataSource = this.hateksPurchasingDataSet;
            // 
            // hateksPurchasingDataSet
            // 
            this.hateksPurchasingDataSet.DataSetName = "HateksPurchasingDataSet";
            this.hateksPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 636);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewDraftReportBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(849, 566);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDraftId,
            this.colDraftTypeName,
            this.colItemName,
            this.colUnitName,
            this.colAmount,
            this.colDescription,
            this.colPrice,
            this.colCurrencyName,
            this.colCurrencyRate,
            this.colGenerateDate,
            this.colTotalPriceText});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colDraftId
            // 
            this.colDraftId.Caption = "FormNo";
            this.colDraftId.FieldName = "DraftId";
            this.colDraftId.MinWidth = 25;
            this.colDraftId.Name = "colDraftId";
            this.colDraftId.Visible = true;
            this.colDraftId.VisibleIndex = 1;
            this.colDraftId.Width = 94;
            // 
            // colDraftTypeName
            // 
            this.colDraftTypeName.Caption = "Departman";
            this.colDraftTypeName.FieldName = "DraftTypeName";
            this.colDraftTypeName.MinWidth = 25;
            this.colDraftTypeName.Name = "colDraftTypeName";
            this.colDraftTypeName.Visible = true;
            this.colDraftTypeName.VisibleIndex = 2;
            this.colDraftTypeName.Width = 94;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Malzeme";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.MinWidth = 25;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            this.colItemName.Width = 94;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Birim";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.MinWidth = 25;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 4;
            this.colUnitName.Width = 94;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Miktar";
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
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
            // colPrice
            // 
            this.colPrice.Caption = "Fiyat";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 7;
            this.colPrice.Width = 94;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Caption = "Kur";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.MinWidth = 25;
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 8;
            this.colCurrencyName.Width = 94;
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
            // colGenerateDate
            // 
            this.colGenerateDate.Caption = "Tarih";
            this.colGenerateDate.FieldName = "GenerateDate";
            this.colGenerateDate.MinWidth = 25;
            this.colGenerateDate.Name = "colGenerateDate";
            this.colGenerateDate.Visible = true;
            this.colGenerateDate.VisibleIndex = 10;
            this.colGenerateDate.Width = 94;
            // 
            // colTotalPriceText
            // 
            this.colTotalPriceText.Caption = "Total Fiyat";
            this.colTotalPriceText.FieldName = "TotalPriceText";
            this.colTotalPriceText.MinWidth = 25;
            this.colTotalPriceText.Name = "colTotalPriceText";
            this.colTotalPriceText.Visible = true;
            this.colTotalPriceText.VisibleIndex = 11;
            this.colTotalPriceText.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 575);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(849, 58);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(427, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(419, 52);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "PDF Aktar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(418, 52);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Excell Aktar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // viewDraftReportTableAdapter
            // 
            this.viewDraftReportTableAdapter.ClearBeforeFill = true;
            // 
            // Exporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Exporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yazdırma Ekranı";
            this.Load += new System.EventHandler(this.Exporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDraftReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HateksPurchasingDataSet hateksPurchasingDataSet;
        private System.Windows.Forms.BindingSource viewDraftReportBindingSource;
        private HateksPurchasingDataSetTableAdapters.ViewDraftReportTableAdapter viewDraftReportTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftId;
        private DevExpress.XtraGrid.Columns.GridColumn colDraftTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colGenerateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}