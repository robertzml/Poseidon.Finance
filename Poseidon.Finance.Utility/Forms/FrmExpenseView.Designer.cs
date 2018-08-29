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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accGroup1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accExpenseItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBizItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gcContext = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContext)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(692, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(583, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.splitContainerControl1);
            this.plFill.Size = new System.Drawing.Size(784, 402);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 402);
            this.plBottom.Size = new System.Drawing.Size(784, 60);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.accordionControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcContext);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(784, 402);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accGroup1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(158, 402);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // accGroup1
            // 
            this.accGroup1.Appearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.accGroup1.Appearance.Normal.Options.UseForeColor = true;
            this.accGroup1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accExpenseItem,
            this.accBizItem});
            this.accGroup1.Expanded = true;
            this.accGroup1.Tag = "Head";
            this.accGroup1.Text = "关联信息";
            // 
            // accExpenseItem
            // 
            this.accExpenseItem.Image = ((System.Drawing.Image)(resources.GetObject("accExpenseItem.Image")));
            this.accExpenseItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accExpenseItem.Tag = "Expense";
            this.accExpenseItem.Text = "费用信息";
            // 
            // accBizItem
            // 
            this.accBizItem.Image = ((System.Drawing.Image)(resources.GetObject("accBizItem.Image")));
            this.accBizItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBizItem.Tag = "Biz";
            this.accBizItem.Text = "业务信息";
            // 
            // gcContext
            // 
            this.gcContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContext.Location = new System.Drawing.Point(0, 0);
            this.gcContext.Name = "gcContext";
            this.gcContext.Size = new System.Drawing.Size(621, 402);
            this.gcContext.TabIndex = 0;
            this.gcContext.Text = "信息";
            // 
            // FrmExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Name = "FrmExpenseView";
            this.Text = "费用信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl gcContext;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGroup1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accExpenseItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accBizItem;
    }
}