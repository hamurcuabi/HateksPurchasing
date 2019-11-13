namespace HateksPurchasing
{
    partial class AddOrUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateMember));
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new DevExpress.XtraEditors.CheckButton();
            this.btnDone = new DevExpress.XtraEditors.CheckButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.memberTableAdapter1 = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.MemberTableAdapter();
            this.lookupPerm = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.hateksPurchasingDataSet = new HateksPurchasing.HateksPurchasingDataSet();
            this.formPermsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formPermsTableAdapter = new HateksPurchasing.HateksPurchasingDataSetTableAdapters.FormPermsTableAdapter();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupPerm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPermsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(148, 146);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(327, 22);
            this.txtMail.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 28);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Email:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(89, 195);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 28);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Şifre:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDone, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 95);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(25);
            this.btnCancel.Size = new System.Drawing.Size(225, 75);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.CheckedChanged += new System.EventHandler(this.btnCancel_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone.ImageOptions.SvgImage")));
            this.btnDone.Location = new System.Drawing.Point(255, 10);
            this.btnDone.Margin = new System.Windows.Forms.Padding(10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Padding = new System.Windows.Forms.Padding(25);
            this.btnDone.Size = new System.Drawing.Size(225, 75);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "TAMAM";
            this.btnDone.CheckedChanged += new System.EventHandler(this.btnDone_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 22);
            this.txtName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(107, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 28);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Ad:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Mask.EditMask = "d";
            this.txtPassword.Size = new System.Drawing.Size(327, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(148, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(327, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(73, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 28);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Soyad:";
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // lookupPerm
            // 
            this.lookupPerm.EditValue = "";
            this.lookupPerm.Location = new System.Drawing.Point(148, 256);
            this.lookupPerm.Name = "lookupPerm";
            this.lookupPerm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupPerm.Properties.DataSource = this.formPermsBindingSource;
            this.lookupPerm.Properties.DisplayMember = "Descp";
            this.lookupPerm.Properties.PopupView = this.gridLookUpEdit1View;
            this.lookupPerm.Properties.ValueMember = "Id";
            this.lookupPerm.Size = new System.Drawing.Size(327, 22);
            this.lookupPerm.TabIndex = 33;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescp});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(148, 306);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(327, 22);
            this.txtUsername.TabIndex = 34;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 28);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Kullanıcı Adı:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(80, 250);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 28);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Yetki:";
            // 
            // hateksPurchasingDataSet
            // 
            this.hateksPurchasingDataSet.DataSetName = "HateksPurchasingDataSet";
            this.hateksPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formPermsBindingSource
            // 
            this.formPermsBindingSource.DataMember = "FormPerms";
            this.formPermsBindingSource.DataSource = this.hateksPurchasingDataSet;
            // 
            // formPermsTableAdapter
            // 
            this.formPermsTableAdapter.ClearBeforeFill = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colDescp
            // 
            this.colDescp.Caption = "Yetki Türü";
            this.colDescp.FieldName = "Descp";
            this.colDescp.MinWidth = 25;
            this.colDescp.Name = "colDescp";
            this.colDescp.Visible = true;
            this.colDescp.VisibleIndex = 0;
            this.colDescp.Width = 94;
            // 
            // AddOrUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 476);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lookupPerm);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Name = "AddOrUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullancıı Ekle-Güncelle";
            this.Load += new System.EventHandler(this.AddOrUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupPerm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hateksPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPermsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.CheckButton btnCancel;
        private DevExpress.XtraEditors.CheckButton btnDone;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private HateksPurchasingDataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private DevExpress.XtraEditors.GridLookUpEdit lookupPerm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private HateksPurchasingDataSet hateksPurchasingDataSet;
        private System.Windows.Forms.BindingSource formPermsBindingSource;
        private HateksPurchasingDataSetTableAdapters.FormPermsTableAdapter formPermsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescp;
    }
}