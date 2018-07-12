namespace Poseidon.Finance.ClientDx
{
    partial class CategoryTree
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
            this.components = new System.ComponentModel.Container();
            this.tlCategory = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colStatus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsCategory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tlCategory
            // 
            this.tlCategory.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colNumber,
            this.colParentId,
            this.colSort,
            this.colRemark,
            this.colStatus,
            this.colId});
            this.tlCategory.DataSource = this.bsCategory;
            this.tlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCategory.KeyFieldName = "Id";
            this.tlCategory.Location = new System.Drawing.Point(0, 0);
            this.tlCategory.Name = "tlCategory";
            this.tlCategory.OptionsBehavior.Editable = false;
            this.tlCategory.OptionsBehavior.PopulateServiceColumns = true;
            this.tlCategory.OptionsFilter.AllowFilterEditor = false;
            this.tlCategory.ParentFieldName = "ParentId";
            this.tlCategory.Size = new System.Drawing.Size(674, 496);
            this.tlCategory.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 98;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "分类号";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 1;
            this.colNumber.Width = 99;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Width = 98;
            // 
            // colSort
            // 
            this.colSort.Caption = "排序码";
            this.colSort.FieldName = "Sort";
            this.colSort.Name = "colSort";
            this.colSort.Visible = true;
            this.colSort.VisibleIndex = 2;
            this.colSort.Width = 98;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 3;
            this.colRemark.Width = 98;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 97;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 97;
            // 
            // bsCategory
            // 
            this.bsCategory.DataSource = typeof(Poseidon.Finance.Core.DL.Category);
            // 
            // CategoryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlCategory);
            this.Name = "CategoryTree";
            this.Size = new System.Drawing.Size(674, 496);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colStatus;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private System.Windows.Forms.BindingSource bsCategory;
    }
}
