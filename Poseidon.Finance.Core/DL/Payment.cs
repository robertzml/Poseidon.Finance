using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 付款类
    /// </summary>
    public class Payment : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 流水号
        /// </summary>
        [Display(Name = "流水号")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 经费本ID
        /// </summary>
        [Display(Name = "经费本ID")]
        public string FundId { get; set; }

        /// <summary>
        /// 经费本名称
        /// </summary>
        [Display(Name = "经费本名称")]
        public string FundName { get; set; }

        /// <summary>
        /// 经费本号
        /// </summary>
        [Display(Name = "经费本号")]
        public string FundNumber { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }

        /// <summary>
        /// 收款方
        /// </summary>
        [Display(Name = "收款方")]
        public string Recipient { get; set; }

        /// <summary>
        /// 经办人
        /// </summary>
        [Display(Name = "经办人")]
        public string Operator { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [Display(Name = "付款金额")]
        public decimal PaidFee { get; set; }

        /// <summary>
        /// 付款日期
        /// </summary>
        [Display(Name = "付款日期")]
        public DateTime PaidDate { get; set; }

        /// <summary>
        /// 是否入账
        /// </summary>
        [Display(Name = "是否入账")]
        public bool IsPost { get; set; }

        /// <summary>
        /// 付款明细
        /// </summary>
        [Display(Name = "付款明细")]
        public List<PaymentRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 付款明细类
    /// </summary>
    public class PaymentRecord : BaseEntity
    {
        /// <summary>
        /// 付款ID
        /// </summary>
        [Display(Name = "付款ID")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 费用ID
        /// </summary>
        [Display(Name = "费用ID")]
        public string ExpenseId { get; set; }

        /// <summary>
        /// 费用总金额
        /// </summary>
        [Display(Name = "费用总金额")]
        public decimal ExpenseFee { get; set; }

        /// <summary>
        /// 待支付金额
        /// </summary>
        [Display(Name = "待支付金额")]
        public decimal RemainFee { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [Display(Name = "付款金额")]
        public decimal PaidFee { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
