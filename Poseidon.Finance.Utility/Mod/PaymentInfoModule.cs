using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.Utility
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 付款信息模块
    /// </summary>
    public partial class PaymentInfoModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联付款
        /// </summary>
        private Payment currentPayment;
        #endregion //Field

        #region Constructor
        public PaymentInfoModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示信息
        /// </summary>
        private void Display()
        {
            this.txtSerialNumber.Text = this.currentPayment.SerialNumber;
            this.txtSummary.Text = this.currentPayment.Summary;
            this.txtFundName.Text = this.currentPayment.FundName;
            this.txtFundNumber.Text = this.currentPayment.FundNumber;
            this.txtPaidFee.Text = this.currentPayment.PaidFee.ToString();
            this.chkIsPost.Checked = this.currentPayment.IsPost;
            this.txtPaidDate.Text = this.currentPayment.PaidDate.ToDateString();
            this.txtRecipient.Text = this.currentPayment.Recipient;
            this.txtOperator.Text = this.currentPayment.Operator;
            this.txtCreator.Text = this.currentPayment.CreateBy.Name;
            this.txtCreateTime.Text = this.currentPayment.CreateBy.Time.ToDateTimeString();
            this.txtEditor.Text = this.currentPayment.UpdateBy.Name;
            this.txtEditTime.Text = this.currentPayment.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = this.currentPayment.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="payment">付款记录</param>
        public void Init(Payment payment)
        {
            this.currentPayment = payment;
            this.Display();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtSerialNumber.Text = "";
            this.txtSummary.Text = "";
            this.txtFundName.Text = "";
            this.txtFundNumber.Text = "";
            this.txtPaidFee.Text = "";
            this.chkIsPost.Checked = false;
            this.txtPaidDate.Text = "";
            this.txtRecipient.Text = "";
            this.txtOperator.Text = "";
            this.txtCreator.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditor.Text = "";
            this.txtEditTime.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
