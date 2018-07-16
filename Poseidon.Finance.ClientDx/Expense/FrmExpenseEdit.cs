using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 编辑用款窗体
    /// </summary>
    public partial class FrmExpenseEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联用款
        /// </summary>
        private Expense currentExpense;
        #endregion //Field

        #region Constructor
        public FrmExpenseEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentExpense = BusinessFactory<ExpenseBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsCategory.DataSource = BusinessFactory<CategoryBusiness>.Instance.FindAll();

            this.txtSummary.Text = this.currentExpense.Summary;
            this.spAmount.Value = this.currentExpense.Amount;
            this.tluCategory.EditValue = this.currentExpense.CategoryNumber;
            this.dpExpenseDate.DateTime = this.currentExpense.ExpenseDate;
            this.txtOperator.Text = this.currentExpense.Operator;
            this.txtRemark.Text = this.currentExpense.Remark;

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
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Expense entity = BusinessFactory<ExpenseBusiness>.Instance.FindById(this.currentExpense.Id);
                SetEntity(entity);

                BusinessFactory<ExpenseBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("更新付款失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
