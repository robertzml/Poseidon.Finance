using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.Utility
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Common;

    /// <summary>
    /// 新增用款窗体
    /// </summary>
    public partial class FrmExpenseAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 模块名称
        /// </summary>
        private string moduleName;

        /// <summary>
        /// 程序集名称
        /// </summary>
        private string assemblyName;

        /// <summary>
        /// 集合名称
        /// </summary>
        private string collectionName;

        /// <summary>
        /// 文档ID
        /// </summary>
        private string documentId;
        #endregion //Field

        #region Constructor
        public FrmExpenseAdd(string moduleName, string assemblyName, string collectionName, string documentId)
        {
            InitializeComponent();

            InitData(moduleName, assemblyName, collectionName, documentId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string moduleName, string assemblyName, string collectionName, string documentId)
        {
            this.moduleName = moduleName;
            this.assemblyName = assemblyName;
            this.collectionName = collectionName;
            this.documentId = documentId;
        }

        protected override void InitForm()
        {
            this.bsCategory.DataSource = BusinessFactory<CategoryBusiness>.Instance.FindAll();
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtSummary.Text.Trim()))
            {
                errorMessage = "摘要不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.tluCategory.EditValue == null)
            {
                errorMessage = "请选择费用分类";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpExpenseDate.EditValue == null)
            {
                errorMessage = "请选择用款日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Expense entity)
        {
            entity.Summary = this.txtSummary.Text;
            entity.Amount = this.spAmount.Value;

            var category = this.tluCategory.GetSelectedDataRow() as Category;
            entity.CategoryNumber = category.Number;
            entity.CategoryName = category.Name;
            entity.Operator = this.txtOperator.Text;
            entity.ExpenseDate = this.dpExpenseDate.DateTime;
            entity.Remark = this.txtRemark.Text;

            entity.ModuleName = this.moduleName;
            entity.AssemblyName = this.assemblyName;
            entity.CollectionName = this.collectionName;
            entity.DocumentId = this.documentId;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
