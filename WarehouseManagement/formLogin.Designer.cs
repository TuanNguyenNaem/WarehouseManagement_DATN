namespace WarehouseManagement
{
    partial class formLogin
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btback = new DevExpress.XtraEditors.SimpleButton();
            this.btlogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.checkShowpass = new DevExpress.XtraEditors.CheckEdit();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.btback);
            this.layoutControl1.Controls.Add(this.btlogin);
            this.layoutControl1.Controls.Add(this.txtpass);
            this.layoutControl1.Controls.Add(this.checkShowpass);
            this.layoutControl1.Controls.Add(this.txtusername);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(751, 14, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(473, 179);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::WarehouseManagement.Properties.Resources.login_icon;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 155);
            this.label1.TabIndex = 10;
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(295, 135);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(72, 22);
            this.btback.StyleController = this.layoutControl1;
            this.btback.TabIndex = 9;
            this.btback.Text = "Back";
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(381, 135);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(80, 22);
            this.btlogin.StyleController = this.layoutControl1;
            this.btlogin.TabIndex = 8;
            this.btlogin.Text = "Login";
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(263, 70);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(198, 20);
            this.txtpass.TabIndex = 7;
            // 
            // checkShowpass
            // 
            this.checkShowpass.Location = new System.Drawing.Point(266, 94);
            this.checkShowpass.Name = "checkShowpass";
            this.checkShowpass.Properties.Caption = "Show password";
            this.checkShowpass.Size = new System.Drawing.Size(195, 20);
            this.checkShowpass.StyleController = this.layoutControl1;
            this.checkShowpass.TabIndex = 6;
            this.checkShowpass.CheckedChanged += new System.EventHandler(this.checkShowpass_CheckedChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(263, 36);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(198, 20);
            this.txtusername.StyleController = this.layoutControl1;
            this.txtusername.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.emptySpaceItem8,
            this.emptySpaceItem10,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(473, 179);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(200, 149);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(253, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(253, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(200, 48);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(253, 10);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(253, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(253, 10);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(200, 82);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(54, 24);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(54, 24);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(54, 24);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtusername;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(253, 24);
            this.layoutControlItem1.Text = "Username";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkShowpass;
            this.layoutControlItem3.Location = new System.Drawing.Point(254, 82);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtpass;
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 58);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(253, 24);
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btlogin;
            this.layoutControlItem4.Location = new System.Drawing.Point(369, 123);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(84, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btback;
            this.layoutControlItem5.Location = new System.Drawing.Point(283, 123);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(76, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(200, 106);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(253, 17);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(253, 17);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(253, 17);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(200, 123);
            this.emptySpaceItem8.MaxSize = new System.Drawing.Size(83, 26);
            this.emptySpaceItem8.MinSize = new System.Drawing.Size(83, 26);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(83, 26);
            this.emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(359, 123);
            this.emptySpaceItem10.MaxSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem10.MinSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.label1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 159);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(200, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(253, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 179);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLogin_FormClosed);
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkShowpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btback;
        private DevExpress.XtraEditors.SimpleButton btlogin;
        private System.Windows.Forms.TextBox txtpass;
        private DevExpress.XtraEditors.CheckEdit checkShowpass;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}