﻿namespace Poseidon.Finance.ClientDx
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
            this.btnCalc = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.dpPaidDate = new DevExpress.XtraEditors.DateEdit();
            this.spPaidFee = new DevExpress.XtraEditors.SpinEdit();
            this.spRemission = new DevExpress.XtraEditors.SpinEdit();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.spSumFee = new DevExpress.XtraEditors.SpinEdit();
            this.txtSummary = new DevExpress.XtraEditors.TextEdit();
            this.luFund = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bsFund = new System.Windows.Forms.BindingSource(this.components);
            this.expenseGrid = new Poseidon.Finance.Utility.ExpenseGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRemission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSumFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFund)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.btnCalc);
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
            this.layoutControl1.Size = new System.Drawing.Size(974, 197);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(725, 163);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(237, 22);
            this.btnCalc.StyleController = this.layoutControl1;
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "确认用款选择";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
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
            this.dpPaidDate.Location = new System.Drawing.Point(322, 12);
            this.dpPaidDate.Name = "dpPaidDate";
            this.dpPaidDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpPaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPaidDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpPaidDate.Size = new System.Drawing.Size(163, 20);
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
            this.spPaidFee.Location = new System.Drawing.Point(800, 36);
            this.spPaidFee.Name = "spPaidFee";
            this.spPaidFee.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.spPaidFee.Properties.Appearance.Options.UseBackColor = true;
            this.spPaidFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPaidFee.Properties.ReadOnly = true;
            this.spPaidFee.Size = new System.Drawing.Size(162, 20);
            this.spPaidFee.StyleController = this.layoutControl1;
            this.spPaidFee.TabIndex = 9;
            // 
            // spRemission
            // 
            this.spRemission.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spRemission.Location = new System.Drawing.Point(562, 36);
            this.spRemission.Name = "spRemission";
            this.spRemission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spRemission.Size = new System.Drawing.Size(161, 20);
            this.spRemission.StyleController = this.layoutControl1;
            this.spRemission.TabIndex = 8;
            this.spRemission.EditValueChanged += new System.EventHandler(this.spRemission_EditValueChanged);
            // 
            // spDiscount
            // 
            this.spDiscount.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spDiscount.Location = new System.Drawing.Point(322, 36);
            this.spDiscount.Name = "spDiscount";
            this.spDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDiscount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spDiscount.Size = new System.Drawing.Size(163, 20);
            this.spDiscount.StyleController = this.layoutControl1;
            this.spDiscount.TabIndex = 7;
            this.spDiscount.EditValueChanged += new System.EventHandler(this.spDiscount_EditValueChanged);
            // 
            // spSumFee
            // 
            this.spSumFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSumFee.Location = new System.Drawing.Point(85, 36);
            this.spSumFee.Name = "spSumFee";
            this.spSumFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSumFee.Size = new System.Drawing.Size(160, 20);
            this.spSumFee.StyleController = this.layoutControl1;
            this.spSumFee.TabIndex = 6;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(562, 12);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(400, 20);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "项目名称", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "项目号", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Principal", "负责人", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance", "项目余额", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AvailableBalance", "可用余额", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatasetCode", "Dataset Code", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status", 45, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.luFund.Properties.DataSource = this.bsFund;
            this.luFund.Properties.DisplayMember = "Name";
            this.luFund.Properties.NullText = "请选择";
            this.luFund.Properties.PopupWidth = 460;
            this.luFund.Properties.ShowFooter = false;
            this.luFund.Properties.ValueMember = "Id";
            this.luFund.Size = new System.Drawing.Size(160, 20);
            this.luFund.StyleController = this.layoutControl1;
            this.luFund.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 197);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luFund;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem1.Text = "经费本";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spSumFee;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem3.Text = "费用合计(元)";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 14);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(477, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(477, 24);
            this.layoutControlItem2.Text = "摘要";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spPaidFee;
            this.layoutControlItem6.Location = new System.Drawing.Point(715, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem6.Text = "实付款(元)";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spDiscount;
            this.layoutControlItem4.Location = new System.Drawing.Point(237, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem4.Text = "折扣率(%)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dpPaidDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(237, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem7.Text = "付款日期";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCalc;
            this.layoutControlItem9.Location = new System.Drawing.Point(713, 151);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(241, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 151);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(713, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spRemission;
            this.layoutControlItem5.Location = new System.Drawing.Point(477, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem5.Text = "减免费用(元)";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 14);
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
            this.groupControl2.Controls.Add(this.expenseGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 229);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(978, 220);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "用款列表";
            // 
            // bsFund
            // 
            this.bsFund.DataSource = typeof(Poseidon.Finance.Core.DL.Fund);
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowFilter = false;
            this.expenseGrid.AllowGroup = false;
            this.expenseGrid.AllowSort = true;
            this.expenseGrid.DataSource = null;
            this.expenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseGrid.Editable = false;
            this.expenseGrid.EnableMasterView = false;
            this.expenseGrid.EnableMultiCheckSelect = true;
            this.expenseGrid.EnableMultiSelect = true;
            this.expenseGrid.Location = new System.Drawing.Point(2, 21);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ShowAddMenu = false;
            this.expenseGrid.ShowAssembly = false;
            this.expenseGrid.ShowFooter = false;
            this.expenseGrid.ShowLineNumber = true;
            this.expenseGrid.ShowMenu = false;
            this.expenseGrid.ShowNavigator = false;
            this.expenseGrid.Size = new System.Drawing.Size(974, 197);
            this.expenseGrid.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPaidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPaidFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRemission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSumFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luFund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnCalc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}