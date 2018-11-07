namespace Poseidon.Finance.Utility
{
    partial class ExpenseGrid
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCollectionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidFee = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Finance.Core.DL.Expense);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(826, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSerialNumber,
            this.colSummary,
            this.colAmount,
            this.colPaidFee,
            this.colCategoryNumber,
            this.colCategoryName,
            this.colOperator,
            this.colExpenseDate,
            this.colIsPaid,
            this.colModuleName,
            this.colAssemblyName,
            this.colCollectionName,
            this.colDocumentId,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsSelection.MultiSelect = true;
            this.dgvEntity.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // menuView
            // 
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(100, 22);
            this.menuView.Text = "查看";
            this.menuView.Click += new System.EventHandler(this.menuView_Click);
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "流水号";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 1;
            // 
            // colSummary
            // 
            this.colSummary.Caption = "摘要";
            this.colSummary.FieldName = "Summary";
            this.colSummary.Name = "colSummary";
            this.colSummary.Visible = true;
            this.colSummary.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "金额";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colCategoryNumber
            // 
            this.colCategoryNumber.Caption = "分类号";
            this.colCategoryNumber.FieldName = "CategoryNumber";
            this.colCategoryNumber.Name = "colCategoryNumber";
            this.colCategoryNumber.Visible = true;
            this.colCategoryNumber.VisibleIndex = 5;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "分类名称";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 6;
            // 
            // colOperator
            // 
            this.colOperator.Caption = "经办人";
            this.colOperator.FieldName = "Operator";
            this.colOperator.Name = "colOperator";
            this.colOperator.Visible = true;
            this.colOperator.VisibleIndex = 7;
            // 
            // colExpenseDate
            // 
            this.colExpenseDate.Caption = "费用日期";
            this.colExpenseDate.FieldName = "ExpenseDate";
            this.colExpenseDate.Name = "colExpenseDate";
            this.colExpenseDate.Visible = true;
            this.colExpenseDate.VisibleIndex = 8;
            // 
            // colIsPaid
            // 
            this.colIsPaid.Caption = "是否支付";
            this.colIsPaid.FieldName = "IsPaid";
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.Visible = true;
            this.colIsPaid.VisibleIndex = 9;
            // 
            // colModuleName
            // 
            this.colModuleName.Caption = "模块名称";
            this.colModuleName.FieldName = "ModuleName";
            this.colModuleName.Name = "colModuleName";
            this.colModuleName.Visible = true;
            this.colModuleName.VisibleIndex = 10;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.Caption = "程序集名称";
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 11;
            // 
            // colCollectionName
            // 
            this.colCollectionName.Caption = "集合名称";
            this.colCollectionName.FieldName = "CollectionName";
            this.colCollectionName.Name = "colCollectionName";
            this.colCollectionName.Visible = true;
            this.colCollectionName.VisibleIndex = 12;
            // 
            // colDocumentId
            // 
            this.colDocumentId.Caption = "文档ID";
            this.colDocumentId.FieldName = "DocumentId";
            this.colDocumentId.Name = "colDocumentId";
            this.colDocumentId.Visible = true;
            this.colDocumentId.VisibleIndex = 13;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 14;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colPaidFee
            // 
            this.colPaidFee.Caption = "已支付金额";
            this.colPaidFee.FieldName = "PaidFee";
            this.colPaidFee.Name = "colPaidFee";
            this.colPaidFee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaidFee", "合计={0:0.##}")});
            this.colPaidFee.Visible = true;
            this.colPaidFee.VisibleIndex = 4;
            // 
            // ExpenseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExpenseGrid";
            this.Size = new System.Drawing.Size(826, 378);
            this.Load += new System.EventHandler(this.ExpenseGrid_Load);
            this.Controls.SetChildIndex(this.dataNavigator, 0);
            this.Controls.SetChildIndex(this.dgcEntity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colOperator;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colModuleName;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCollectionName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentId;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidFee;
    }
}
