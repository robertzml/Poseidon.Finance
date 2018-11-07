namespace Poseidon.Finance.ClientDx
{
    partial class FrmPaymentManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRevert = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.paymentGrid = new Poseidon.Finance.Utility.PaymentGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.trYear = new DevExpress.XtraTreeList.TreeList();
            this.colYear = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.paymentRecordGrid = new Poseidon.Finance.Utility.PaymentRecordGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(203, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 94);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnRevert);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(714, 71);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(359, 12);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(343, 22);
            this.btnRevert.StyleController = this.layoutControl1;
            this.btnRevert.TabIndex = 8;
            this.btnRevert.Text = "撤回付款";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(343, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增付款";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(714, 71);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(347, 51);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnRevert;
            this.layoutControlItem5.Location = new System.Drawing.Point(347, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(347, 51);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl2, 2);
            this.groupControl2.Controls.Add(this.paymentGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(718, 224);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "付款记录";
            // 
            // paymentGrid
            // 
            this.paymentGrid.AllowFilter = true;
            this.paymentGrid.AllowGroup = true;
            this.paymentGrid.AllowSort = true;
            this.paymentGrid.DataSource = null;
            this.paymentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGrid.Editable = false;
            this.paymentGrid.EnableMasterView = false;
            this.paymentGrid.EnableMultiSelect = true;
            this.paymentGrid.Location = new System.Drawing.Point(2, 21);
            this.paymentGrid.Name = "paymentGrid";
            this.paymentGrid.ShowAddMenu = false;
            this.paymentGrid.ShowDeleteMenu = false;
            this.paymentGrid.ShowEditMenu = false;
            this.paymentGrid.ShowFindPanel = false;
            this.paymentGrid.ShowFooter = true;
            this.paymentGrid.ShowLineNumber = true;
            this.paymentGrid.ShowMenu = false;
            this.paymentGrid.ShowNavigator = false;
            this.paymentGrid.Size = new System.Drawing.Size(714, 201);
            this.paymentGrid.TabIndex = 0;
            this.paymentGrid.RowSelected += new System.Action<object, System.EventArgs>(this.paymentGrid_RowSelected);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.trYear);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl3, 3);
            this.groupControl3.Size = new System.Drawing.Size(194, 554);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "年度选择";
            // 
            // trYear
            // 
            this.trYear.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.trYear.Appearance.FocusedCell.Options.UseBackColor = true;
            this.trYear.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colYear});
            this.trYear.DataSource = null;
            this.trYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trYear.Location = new System.Drawing.Point(2, 21);
            this.trYear.Name = "trYear";
            this.trYear.OptionsBehavior.Editable = false;
            this.trYear.OptionsCustomization.AllowSort = false;
            this.trYear.Size = new System.Drawing.Size(190, 531);
            this.trYear.TabIndex = 0;
            this.trYear.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.trYear_FocusedNodeChanged);
            // 
            // colYear
            // 
            this.colYear.Caption = "年度";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.paymentRecordGrid);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(203, 333);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(356, 224);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "付款明细";
            // 
            // paymentRecordGrid
            // 
            this.paymentRecordGrid.AllowFilter = true;
            this.paymentRecordGrid.AllowGroup = true;
            this.paymentRecordGrid.AllowSort = true;
            this.paymentRecordGrid.DataSource = null;
            this.paymentRecordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentRecordGrid.Editable = false;
            this.paymentRecordGrid.EnableMasterView = false;
            this.paymentRecordGrid.EnableMultiSelect = true;
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
            this.paymentRecordGrid.Size = new System.Drawing.Size(352, 201);
            this.paymentRecordGrid.TabIndex = 0;
            // 
            // FrmPaymentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPaymentManage";
            this.Text = "付款管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Utility.PaymentGrid paymentGrid;
        private DevExpress.XtraEditors.SimpleButton btnRevert;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraTreeList.TreeList trYear;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colYear;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private Utility.PaymentRecordGrid paymentRecordGrid;
    }
}