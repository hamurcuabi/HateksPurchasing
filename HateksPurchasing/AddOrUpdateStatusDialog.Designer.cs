﻿namespace HateksPurchasing
{
    partial class AddOrUpdateStatusDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateStatusDialog));
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.clrpick = new DevExpress.XtraEditors.ColorPickEdit();
            this.txtDescp = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new DevExpress.XtraEditors.CheckButton();
            this.btnDone = new DevExpress.XtraEditors.CheckButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.stateTableAdapter1 = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.StateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrpick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescp.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(339, 22);
            this.txtName.TabIndex = 0;
            // 
            // clrpick
            // 
            this.clrpick.EditValue = System.Drawing.Color.Empty;
            this.clrpick.Location = new System.Drawing.Point(133, 112);
            this.clrpick.Name = "clrpick";
            this.clrpick.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.clrpick.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clrpick.Size = new System.Drawing.Size(339, 22);
            this.clrpick.TabIndex = 1;
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(133, 195);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(339, 117);
            this.txtDescp.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDone, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 337);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 100);
            this.tableLayoutPanel1.TabIndex = 3;
           
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(25);
            this.btnCancel.Size = new System.Drawing.Size(222, 80);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.CheckedChanged += new System.EventHandler(this.btnCancel_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone.ImageOptions.SvgImage")));
            this.btnDone.Location = new System.Drawing.Point(252, 10);
            this.btnDone.Margin = new System.Windows.Forms.Padding(10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Padding = new System.Windows.Forms.Padding(25);
            this.btnDone.Size = new System.Drawing.Size(222, 80);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "TAMAM";
            this.btnDone.CheckedChanged += new System.EventHandler(this.btnDone_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(92, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 28);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 28);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Renk Kodu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 196);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 28);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Açıklama:";
            // 
            // stateTableAdapter1
            // 
            this.stateTableAdapter1.ClearBeforeFill = true;
            // 
            // AddOrUpdateStatusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 437);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clrpick);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescp);
            this.Name = "AddOrUpdateStatusDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Durum Ekle-Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clrpick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescp.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.ColorPickEdit clrpick;
        private DevExpress.XtraEditors.MemoEdit txtDescp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.CheckButton btnCancel;
        private DevExpress.XtraEditors.CheckButton btnDone;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private HateksPurchasingDataSetTableAdapters.StateTableAdapter stateTableAdapter1;
    }
}