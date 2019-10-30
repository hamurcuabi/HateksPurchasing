namespace HateksPurchasing
{
    partial class DashBoard
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.getTotalPriceByDraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hateksPurchasingDataSet1 = new HateksPurchasing.HateksPurchasingDataSet();
            this.getTotalPriceByDraftTableAdapter1 = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.GetTotalPriceByDraftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalPriceByDraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.DataAdapter = this.getTotalPriceByDraftTableAdapter1;
            this.chart.DataSource = this.getTotalPriceByDraftBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Departmanlar";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
            sideBySideBarSeriesView1.FillStyle.Options = hatchFillOptions1;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(790, 620);
            this.chart.TabIndex = 0;
            // 
            // getTotalPriceByDraftBindingSource
            // 
            this.getTotalPriceByDraftBindingSource.DataMember = "GetTotalPriceByDraft";
            this.getTotalPriceByDraftBindingSource.DataSource = this.hateksPurchasingDataSet1;
            this.getTotalPriceByDraftBindingSource.Sort = "";
            // 
            // hateksPurchasingDataSet1
            // 
            this.hateksPurchasingDataSet1.DataSetName = "HateksPurchasingDataSet";
            this.hateksPurchasingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTotalPriceByDraftTableAdapter1
            // 
            this.getTotalPriceByDraftTableAdapter1.ClearBeforeFill = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 620);
            this.Controls.Add(this.chart);
            this.Name = "DashBoard";
            this.Text = "Statistikler";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalPriceByDraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chart;
        private HateksPurchasingDataSetTableAdapters.GetTotalPriceByDraftTableAdapter getTotalPriceByDraftTableAdapter;
        private HateksPurchasingDataSetTableAdapters.GetTotalPriceByDraftTableAdapter getTotalPriceByDraftTableAdapter1;
        private System.Windows.Forms.BindingSource getTotalPriceByDraftBindingSource;
        private HateksPurchasingDataSet hateksPurchasingDataSet1;
    }
}