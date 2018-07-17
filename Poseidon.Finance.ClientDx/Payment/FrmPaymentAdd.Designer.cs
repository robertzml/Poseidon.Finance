namespace Poseidon.Finance.ClientDx
{
    partial class FrmPaymentAdd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.luFund = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSummary = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSumFee = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spRemission = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spPaidFee = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dpPaidDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.expenseGrid = new Poseidon.Finance.Utility.ExpenseGrid();
            this.bsFund = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSumFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRemission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(763, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(654, 15);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(860, 433);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 433);
            this.plBottom.Size = new System.Drawing.Size(860, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(854, 210);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "付款信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.dpPaidDate);
            this.layoutControl1.Controls.Add(this.spPaidFee);
            this.layoutControl1.Controls.Add(this.spRemission);
            this.layoutControl1.Controls.Add(this.spDiscount);
            this.layoutControl1.Controls.Add(this.spSumFee);
            this.layoutControl1.Controls.Add(this.txtSummary);
            this.layoutControl1.Controls.Add(this.luFund);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 187);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 187);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // luFund
            // 
            this.luFund.Location = new System.Drawing.Point(64, 12);
            this.luFund.Name = "luFund";
            this.luFund.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luFund.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "项目名称", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "项目号", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Principal", "负责人", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance", "项目余额", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AvailableBalance", "可用余额", 101, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatasetCode", "Dataset Code", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status", 45, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.luFund.Properties.DataSource = this.bsFund;
            this.luFund.Properties.DisplayMember = "Name";
            this.luFund.Properties.NullText = "请选择";
            this.luFund.Properties.ValueMember = "Id";
            this.luFund.Size = new System.Drawing.Size(359, 20);
            this.luFund.StyleController = this.layoutControl1;
            this.luFund.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luFund;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(415, 24);
            this.layoutControlItem1.Text = "经费本";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(479, 12);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(359, 20);
            this.txtSummary.StyleController = this.layoutControl1;
            this.txtSummary.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSummary;
            this.layoutControlItem2.Location = new System.Drawing.Point(415, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(415, 24);
            this.layoutControlItem2.Text = "摘要";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // spSumFee
            // 
            this.spSumFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSumFee.Location = new System.Drawing.Point(64, 36);
            this.spSumFee.Name = "spSumFee";
            this.spSumFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSumFee.Size = new System.Drawing.Size(774, 20);
            this.spSumFee.StyleController = this.layoutControl1;
            this.spSumFee.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spSumFee;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(830, 24);
            this.layoutControlItem3.Text = "费用合计";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // spDiscount
            // 
            this.spDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDiscount.Location = new System.Drawing.Point(64, 60);
            this.spDiscount.Name = "spDiscount";
            this.spDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDiscount.Size = new System.Drawing.Size(358, 20);
            this.spDiscount.StyleController = this.layoutControl1;
            this.spDiscount.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spDiscount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(414, 24);
            this.layoutControlItem4.Text = "折扣";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // spRemission
            // 
            this.spRemission.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spRemission.Location = new System.Drawing.Point(478, 60);
            this.spRemission.Name = "spRemission";
            this.spRemission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spRemission.Size = new System.Drawing.Size(360, 20);
            this.spRemission.StyleController = this.layoutControl1;
            this.spRemission.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spRemission;
            this.layoutControlItem5.Location = new System.Drawing.Point(414, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(416, 24);
            this.layoutControlItem5.Text = "减免";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // spPaidFee
            // 
            this.spPaidFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPaidFee.Location = new System.Drawing.Point(64, 84);
            this.spPaidFee.Name = "spPaidFee";
            this.spPaidFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPaidFee.Size = new System.Drawing.Size(359, 20);
            this.spPaidFee.StyleController = this.layoutControl1;
            this.spPaidFee.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spPaidFee;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(415, 24);
            this.layoutControlItem6.Text = "实付款";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // dpPaidDate
            // 
            this.dpPaidDate.EditValue = null;
            this.dpPaidDate.Location = new System.Drawing.Point(479, 84);
            this.dpPaidDate.Name = "dpPaidDate";
            this.dpPaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Size = new System.Drawing.Size(359, 20);
            this.dpPaidDate.StyleController = this.layoutControl1;
            this.dpPaidDate.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dpPaidDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(415, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(415, 24);
            this.layoutControlItem7.Text = "付款日期";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(64, 108);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(774, 67);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 11;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtRemark;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(830, 71);
            this.layoutControlItem8.Text = "备注";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 433);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.expenseGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 219);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(854, 211);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "用款列表";
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowFilter = true;
            this.expenseGrid.AllowGroup = false;
            this.expenseGrid.AllowSort = true;
            this.expenseGrid.DataSource = null;
            this.expenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseGrid.Editable = false;
            this.expenseGrid.EnableMasterView = false;
            this.expenseGrid.EnableMultiSelect = true;
            this.expenseGrid.Location = new System.Drawing.Point(2, 21);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ShowAddMenu = false;
            this.expenseGrid.ShowFooter = false;
            this.expenseGrid.ShowLineNumber = true;
            this.expenseGrid.ShowMenu = false;
            this.expenseGrid.ShowNavigator = false;
            this.expenseGrid.Size = new System.Drawing.Size(850, 188);
            this.expenseGrid.TabIndex = 0;
            // 
            // bsFund
            // 
            this.bsFund.DataSource = typeof(Poseidon.Finance.Core.DL.Fund);
            // 
            // FrmPaymentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Name = "FrmPaymentAdd";
            this.Text = "新增付款";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSumFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRemission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DateEdit dpPaidDate;
        private DevExpress.XtraEditors.SpinEdit spPaidFee;
        private DevExpress.XtraEditors.SpinEdit spRemission;
        private DevExpress.XtraEditors.SpinEdit spDiscount;
        private DevExpress.XtraEditors.SpinEdit spSumFee;
        private DevExpress.XtraEditors.TextEdit txtSummary;
        private DevExpress.XtraEditors.LookUpEdit luFund;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bsFund;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Utility.ExpenseGrid expenseGrid;
    }
}