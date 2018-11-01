namespace Poseidon.Finance.Utility
{
    partial class PaymentRecordGrid
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
            this.colPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenseFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Finance.Core.DL.PaymentRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPaymentId,
            this.colExpenseId,
            this.colExpenseFee,
            this.colRemainFee,
            this.colPaidFee,
            this.colRemark});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colPaymentId
            // 
            this.colPaymentId.FieldName = "PaymentId";
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.OptionsColumn.AllowEdit = false;
            this.colPaymentId.Visible = true;
            this.colPaymentId.VisibleIndex = 0;
            // 
            // colExpenseId
            // 
            this.colExpenseId.Caption = "费用摘要";
            this.colExpenseId.FieldName = "ExpenseId";
            this.colExpenseId.Name = "colExpenseId";
            this.colExpenseId.OptionsColumn.AllowEdit = false;
            this.colExpenseId.Visible = true;
            this.colExpenseId.VisibleIndex = 1;
            // 
            // colExpenseFee
            // 
            this.colExpenseFee.FieldName = "ExpenseFee";
            this.colExpenseFee.Name = "colExpenseFee";
            this.colExpenseFee.OptionsColumn.AllowEdit = false;
            this.colExpenseFee.Visible = true;
            this.colExpenseFee.VisibleIndex = 2;
            // 
            // colRemainFee
            // 
            this.colRemainFee.FieldName = "RemainFee";
            this.colRemainFee.Name = "colRemainFee";
            this.colRemainFee.OptionsColumn.AllowEdit = false;
            this.colRemainFee.Visible = true;
            this.colRemainFee.VisibleIndex = 3;
            // 
            // colPaidFee
            // 
            this.colPaidFee.FieldName = "PaidFee";
            this.colPaidFee.Name = "colPaidFee";
            this.colPaidFee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaidFee", "合计={0:0.##}")});
            this.colPaidFee.Visible = true;
            this.colPaidFee.VisibleIndex = 4;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // PaymentRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaymentRecordGrid";
            this.Load += new System.EventHandler(this.PaymentRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colPaymentId;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenseId;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenseFee;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainFee;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidFee;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
