namespace Poseidon.Finance.Utility
{
    partial class PaymentGrid
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
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFundId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFundName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFundNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Finance.Core.DL.Payment);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSerialNumber,
            this.colFundId,
            this.colFundName,
            this.colFundNumber,
            this.colSummary,
            this.colSumFee,
            this.colDiscount,
            this.colRemission,
            this.colPaidFee,
            this.colPaidDate,
            this.colIsPost,
            this.colRemark,
            this.colStatus,
            this.colId});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "流水号";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 0;
            // 
            // colFundId
            // 
            this.colFundId.FieldName = "FundId";
            this.colFundId.Name = "colFundId";
            // 
            // colFundName
            // 
            this.colFundName.Caption = "经费本名称";
            this.colFundName.FieldName = "FundName";
            this.colFundName.Name = "colFundName";
            this.colFundName.Visible = true;
            this.colFundName.VisibleIndex = 1;
            // 
            // colFundNumber
            // 
            this.colFundNumber.Caption = "经费本项目号";
            this.colFundNumber.FieldName = "FundNumber";
            this.colFundNumber.Name = "colFundNumber";
            this.colFundNumber.Visible = true;
            this.colFundNumber.VisibleIndex = 2;
            // 
            // colSummary
            // 
            this.colSummary.Caption = "摘要";
            this.colSummary.FieldName = "Summary";
            this.colSummary.Name = "colSummary";
            this.colSummary.Visible = true;
            this.colSummary.VisibleIndex = 3;
            // 
            // colSumFee
            // 
            this.colSumFee.Caption = "费用合计(元)";
            this.colSumFee.FieldName = "SumFee";
            this.colSumFee.Name = "colSumFee";
            this.colSumFee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumFee", "合计={0:0.##}")});
            this.colSumFee.Visible = true;
            this.colSumFee.VisibleIndex = 4;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "折扣率(%)";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 5;
            // 
            // colRemission
            // 
            this.colRemission.Caption = "减免费用(元)";
            this.colRemission.FieldName = "Remission";
            this.colRemission.Name = "colRemission";
            this.colRemission.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Remission", "合计={0:0.##}")});
            this.colRemission.Visible = true;
            this.colRemission.VisibleIndex = 6;
            // 
            // colPaidFee
            // 
            this.colPaidFee.Caption = "实付款(元)";
            this.colPaidFee.FieldName = "PaidFee";
            this.colPaidFee.Name = "colPaidFee";
            this.colPaidFee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaidFee", "合计={0:0.##}")});
            this.colPaidFee.Visible = true;
            this.colPaidFee.VisibleIndex = 7;
            // 
            // colPaidDate
            // 
            this.colPaidDate.Caption = "付款日期";
            this.colPaidDate.FieldName = "PaidDate";
            this.colPaidDate.Name = "colPaidDate";
            this.colPaidDate.Visible = true;
            this.colPaidDate.VisibleIndex = 8;
            // 
            // colIsPost
            // 
            this.colIsPost.Caption = "是否入账";
            this.colIsPost.FieldName = "IsPost";
            this.colIsPost.Name = "colIsPost";
            this.colIsPost.Visible = true;
            this.colIsPost.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // PaymentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaymentGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFundId;
        private DevExpress.XtraGrid.Columns.GridColumn colFundName;
        private DevExpress.XtraGrid.Columns.GridColumn colFundNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colSumFee;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemission;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidFee;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPost;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
