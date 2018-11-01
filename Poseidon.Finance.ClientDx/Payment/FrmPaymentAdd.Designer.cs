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
            this.btnAddRecord = new DevExpress.XtraEditors.SimpleButton();
            this.txtOperator = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.dpPaidDate = new DevExpress.XtraEditors.DateEdit();
            this.spPaidFee = new DevExpress.XtraEditors.SpinEdit();
            this.txtSummary = new DevExpress.XtraEditors.TextEdit();
            this.luFund = new DevExpress.XtraEditors.LookUpEdit();
            this.bsFund = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteRecord = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.paymentRecordGrid = new Poseidon.Finance.Utility.PaymentRecordGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(887, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(778, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(984, 452);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 452);
            this.plBottom.Size = new System.Drawing.Size(984, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(978, 220);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "付款信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDeleteRecord);
            this.layoutControl1.Controls.Add(this.btnAddRecord);
            this.layoutControl1.Controls.Add(this.txtOperator);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.dpPaidDate);
            this.layoutControl1.Controls.Add(this.spPaidFee);
            this.layoutControl1.Controls.Add(this.txtSummary);
            this.layoutControl1.Controls.Add(this.luFund);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(974, 197);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(601, 163);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(159, 22);
            this.btnAddRecord.StyleController = this.layoutControl1;
            this.btnAddRecord.TabIndex = 14;
            this.btnAddRecord.Text = "增加付款记录";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(718, 36);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(244, 20);
            this.txtOperator.StyleController = this.layoutControl1;
            this.txtOperator.TabIndex = 13;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(85, 60);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(877, 99);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 11;
            // 
            // dpPaidDate
            // 
            this.dpPaidDate.EditValue = null;
            this.dpPaidDate.Location = new System.Drawing.Point(388, 36);
            this.dpPaidDate.Name = "dpPaidDate";
            this.dpPaidDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpPaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpPaidDate.Size = new System.Drawing.Size(253, 20);
            this.dpPaidDate.StyleController = this.layoutControl1;
            this.dpPaidDate.TabIndex = 10;
            // 
            // spPaidFee
            // 
            this.spPaidFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPaidFee.Location = new System.Drawing.Point(85, 36);
            this.spPaidFee.Name = "spPaidFee";
            this.spPaidFee.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.spPaidFee.Properties.Appearance.Options.UseBackColor = true;
            this.spPaidFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPaidFee.Size = new System.Drawing.Size(226, 20);
            this.spPaidFee.StyleController = this.layoutControl1;
            this.spPaidFee.TabIndex = 9;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(388, 12);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(574, 20);
            this.txtSummary.StyleController = this.layoutControl1;
            this.txtSummary.TabIndex = 5;
            // 
            // luFund
            // 
            this.luFund.Location = new System.Drawing.Point(85, 12);
            this.luFund.Name = "luFund";
            this.luFund.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luFund.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "项目名称", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "项目号", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Principal", "负责人", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance", "项目余额", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AvailableBalance", "可用余额", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatasetCode", "Dataset Code", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status", 45, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luFund.Properties.DataSource = this.bsFund;
            this.luFund.Properties.DisplayMember = "Name";
            this.luFund.Properties.NullText = "请选择";
            this.luFund.Properties.PopupWidth = 460;
            this.luFund.Properties.ShowFooter = false;
            this.luFund.Properties.ValueMember = "Id";
            this.luFund.Size = new System.Drawing.Size(226, 20);
            this.luFund.StyleController = this.layoutControl1;
            this.luFund.TabIndex = 4;
            // 
            // bsFund
            // 
            this.bsFund.DataSource = typeof(Poseidon.Finance.Core.DL.Fund);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 197);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luFund;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(303, 24);
            this.layoutControlItem1.Text = "经费本";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtRemark;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(954, 103);
            this.layoutControlItem8.Text = "备注";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSummary;
            this.layoutControlItem2.Location = new System.Drawing.Point(303, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(651, 24);
            this.layoutControlItem2.Text = "摘要";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spPaidFee;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(303, 24);
            this.layoutControlItem6.Text = "付款金额(元)";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 151);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(589, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dpPaidDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(303, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(330, 24);
            this.layoutControlItem7.Text = "付款日期";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtOperator;
            this.layoutControlItem3.Location = new System.Drawing.Point(633, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem3.Text = "经办人";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAddRecord;
            this.layoutControlItem4.Location = new System.Drawing.Point(589, 151);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 452);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.paymentRecordGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 229);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(978, 220);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "相关付款记录";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(764, 163);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(198, 22);
            this.btnDeleteRecord.StyleController = this.layoutControl1;
            this.btnDeleteRecord.TabIndex = 15;
            this.btnDeleteRecord.Text = "删除付款记录";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDeleteRecord;
            this.layoutControlItem5.Location = new System.Drawing.Point(752, 151);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(202, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // paymentRecordGrid
            // 
            this.paymentRecordGrid.AllowFilter = false;
            this.paymentRecordGrid.AllowGroup = false;
            this.paymentRecordGrid.AllowSort = true;
            this.paymentRecordGrid.DataSource = null;
            this.paymentRecordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentRecordGrid.Editable = true;
            this.paymentRecordGrid.EnableMasterView = false;
            this.paymentRecordGrid.EnableMultiSelect = false;
            this.paymentRecordGrid.Location = new System.Drawing.Point(2, 21);
            this.paymentRecordGrid.Name = "paymentRecordGrid";
            this.paymentRecordGrid.ShowAddMenu = false;
            this.paymentRecordGrid.ShowDeleteMenu = false;
            this.paymentRecordGrid.ShowEditMenu = false;
            this.paymentRecordGrid.ShowFindPanel = false;
            this.paymentRecordGrid.ShowFooter = true;
            this.paymentRecordGrid.ShowLineNumber = true;
            this.paymentRecordGrid.ShowMenu = false;
            this.paymentRecordGrid.ShowNavigator = false;
            this.paymentRecordGrid.ShowPaymentColumn = false;
            this.paymentRecordGrid.Size = new System.Drawing.Size(974, 197);
            this.paymentRecordGrid.TabIndex = 0;
            // 
            // FrmPaymentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DateEdit dpPaidDate;
        private DevExpress.XtraEditors.SpinEdit spPaidFee;
        private DevExpress.XtraEditors.TextEdit txtSummary;
        private DevExpress.XtraEditors.LookUpEdit luFund;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bsFund;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtOperator;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Utility.PaymentRecordGrid paymentRecordGrid;
        private DevExpress.XtraEditors.SimpleButton btnAddRecord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRecord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}