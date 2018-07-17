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
    /// 新增付款窗体
    /// </summary>
    public partial class FrmPaymentAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 选择付款
        /// </summary>
        private List<Expense> selectExpenses;
        #endregion //Field

        #region Constructor
        public FrmPaymentAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.selectExpenses = new List<Expense>();

            this.bsFund.DataSource = BusinessFactory<FundBusiness>.Instance.FindAll();

            var exp = BusinessFactory<ExpenseBusiness>.Instance.FindUnPaid();
            this.expenseGrid.DataSource = exp.ToList();

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.luFund.EditValue == null)
            {
                errorMessage = "请选择经费本";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtSummary.Text.Trim()))
            {
                errorMessage = "摘要不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpPaidDate.EditValue == null)
            {
                errorMessage = "请选择付款日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Payment entity)
        {
            var fund = this.luFund.GetSelectedDataRow() as Fund;
            entity.FundId = fund.Id;
            entity.FundName = fund.Name;
            entity.FundNumber = fund.Number;

            entity.Summary = this.txtSummary.Text;
            entity.PaidDate = this.dpPaidDate.DateTime;

            entity.SumFee = this.spSumFee.Value;
            entity.Discount = this.spDiscount.Value;
            entity.Remission = this.spRemission.Value;
            entity.PaidFee = this.spPaidFee.Value;
            entity.Remark = this.txtRemark.Text;

            entity.ExpenseIds = this.selectExpenses.Select(r => r.Id).ToList();
        }

        /// <summary>
        /// 计算应付款
        /// </summary>
        private void CalculatePaidFee()
        {
            var paidFee = this.spSumFee.Value * this.spDiscount.Value / 100 - this.spRemission.Value;
            this.spPaidFee.Value = paidFee;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 确认用款选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.selectExpenses = this.expenseGrid.GetSelectedRows();

            this.spSumFee.Value = this.selectExpenses.Sum(r => r.Amount);

            CalculatePaidFee();
        }

        /// <summary>
        /// 改变折扣率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculatePaidFee();
        }

        /// <summary>
        /// 改变减免费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spRemission_EditValueChanged(object sender, EventArgs e)
        {
            CalculatePaidFee();
        }

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
                Payment entity = new Payment();
                SetEntity(entity);

                BusinessFactory<PaymentBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增付款记录失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
