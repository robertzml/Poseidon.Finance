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

            this.dpPaidDate.DateTime = DateTime.Now.Date;
            this.bsFund.DataSource = BusinessFactory<FundBusiness>.Instance.FindAll();
            this.paymentRecordGrid.DataSource = new List<PaymentRecord>();

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private (bool success, string errorMessage) CheckInput()
        {
            string errorMessage = "";

            if (this.luFund.EditValue == null)
            {
                errorMessage = "请选择经费本";
                return (false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtSummary.Text.Trim()))
            {
                errorMessage = "摘要不能为空";
                return (false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtOperator.Text.Trim()))
            {
                errorMessage = "经办人不能为空";
                return (false, errorMessage);
            }
            if (this.dpPaidDate.EditValue == null)
            {
                errorMessage = "请选择付款日期";
                return (false, errorMessage);
            }
            foreach (var item in this.paymentRecordGrid.DataSource)
            {
                if (item.PaidFee <= 0)
                {
                    errorMessage = "付款金额必须大于0";
                    return (false, errorMessage);
                }
                if (item.PaidFee > item.RemainFee)
                {
                    errorMessage = "付款金额大于待付金额";
                    return (false, errorMessage);
                }
            }

            return (true, "");
        }

        /// <summary>
        /// 转换为支付记录
        /// </summary>
        /// <param name="expenses">费用记录</param>
        private void TransToPaymentRecord(List<Expense> expenses)
        {
            var data = this.paymentRecordGrid.DataSource;

            foreach (var item in expenses)
            {
                if (data.Any(r => r.ExpenseId == item.Id))
                    continue;

                PaymentRecord record = new PaymentRecord();
                record.ExpenseId = item.Id;
                record.ExpenseFee = item.Amount;
                record.RemainFee = item.Amount - item.PaidFee;
                record.Remark = "";

                data.Add(record);
            }

            this.paymentRecordGrid.UpdateBindingData();
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
            entity.Operator = this.txtOperator.Text;         
            entity.PaidDate = this.dpPaidDate.DateTime;
            entity.Remark = this.txtRemark.Text;

            entity.Records = this.paymentRecordGrid.DataSource;            
            foreach (var item in entity.Records)
            {
                item.Remark = item.Remark ?? "";
            }

            entity.PaidFee = entity.Records.Sum(r => r.PaidFee);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 增加付款记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            FrmExpenseSearch frm = new FrmExpenseSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TransToPaymentRecord(frm.SelectExpenses);
            }
        }

        /// <summary>
        /// 删除付款记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            var select = this.paymentRecordGrid.GetCurrentSelect();
            if (select != null)
            {
                this.paymentRecordGrid.DataSource.Remove(select);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.success)
            {
                MessageUtil.ShowError(input.errorMessage);
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
