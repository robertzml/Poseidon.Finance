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
    /// 编辑付款窗体
    /// </summary>
    public partial class FrmPaymentEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联付款
        /// </summary>
        private Payment currentPayment;

        /// <summary>
        /// 选择付款
        /// </summary>
        private List<Expense> selectExpenses;
        #endregion //Field

        #region Constructor
        public FrmPaymentEdit(string id)
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
            this.currentPayment = BusinessFactory<PaymentBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsFund.DataSource = BusinessFactory<FundBusiness>.Instance.FindAll();

            this.luFund.EditValue = this.currentPayment.FundId;
            this.txtSummary.Text = this.currentPayment.Summary;
            this.spPaidFee.Value = this.currentPayment.PaidFee;
            this.dpPaidDate.DateTime = this.currentPayment.PaidDate;
            this.txtOperator.Text = this.currentPayment.Operator;
            this.txtRemark.Text = this.currentPayment.Remark;

            this.paymentRecordGrid.DataSource = this.currentPayment.Records;

            base.InitForm();
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
                //TransToPaymentRecord(frm.SelectExpenses);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
