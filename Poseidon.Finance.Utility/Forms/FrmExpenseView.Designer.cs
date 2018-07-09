namespace Poseidon.Finance.Utility
{
    partial class FrmExpenseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenseView));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgExpense = new DevExpress.XtraNavBar.NavBarGroup();
            this.navExpenseItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBizItem = new DevExpress.XtraNavBar.NavBarItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcContext = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContext)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(602, 18);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(493, 18);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.splitContainerControl1);
            this.plFill.Size = new System.Drawing.Size(708, 418);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 418);
            this.plBottom.Size = new System.Drawing.Size(708, 60);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgExpense;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgExpense});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navExpenseItem,
            this.navBizItem});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 158;
            this.navBarControl1.ShowIcons = DevExpress.Utils.DefaultBoolean.True;
            this.navBarControl1.Size = new System.Drawing.Size(158, 418);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            // 
            // nbgExpense
            // 
            this.nbgExpense.Caption = "关联信息";
            this.nbgExpense.Expanded = true;
            this.nbgExpense.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navExpenseItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBizItem)});
            this.nbgExpense.Name = "nbgExpense";
            this.nbgExpense.ShowIcons = DevExpress.Utils.DefaultBoolean.True;
            // 
            // navExpenseItem
            // 
            this.navExpenseItem.Caption = "用款信息";
            this.navExpenseItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("navExpenseItem.LargeImage")));
            this.navExpenseItem.Name = "navExpenseItem";
            this.navExpenseItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navExpenseItem.SmallImage")));
            this.navExpenseItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navExpenseItem_LinkClicked);
            // 
            // navBizItem
            // 
            this.navBizItem.Caption = "业务信息";
            this.navBizItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBizItem.LargeImage")));
            this.navBizItem.Name = "navBizItem";
            this.navBizItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBizItem.SmallImage")));
            this.navBizItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBizItem_LinkClicked_1);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcContext);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(708, 418);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcContext
            // 
            this.gcContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContext.Location = new System.Drawing.Point(0, 0);
            this.gcContext.Name = "gcContext";
            this.gcContext.Size = new System.Drawing.Size(545, 418);
            this.gcContext.TabIndex = 0;
            this.gcContext.Text = "groupControl1";
            // 
            // FrmExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 478);
            this.Name = "FrmExpenseView";
            this.Text = "用款信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgExpense;
        private DevExpress.XtraNavBar.NavBarItem navExpenseItem;
        private DevExpress.XtraNavBar.NavBarItem navBizItem;
        private DevExpress.XtraEditors.GroupControl gcContext;
    }
}