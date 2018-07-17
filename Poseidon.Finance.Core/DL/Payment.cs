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
        /// 费用合计
        /// </summary>
        [Display(Name = "费用合计")]
        public decimal SumFee { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [Display(Name = "折扣率")]
        public decimal Discount { get; set; }

        /// <summary>
        /// 减免
        /// </summary>
        [Display(Name = "减免")]
        public decimal Remission { get; set; }

        /// <summary>
        /// 实付款
        /// </summary>
        [Display(Name = "实付款")]
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
        /// 用款记录
        /// </summary>
        [Display(Name = "用款记录")]
        public List<string> ExpenseIds { get; set; }
        #endregion //Property
    }
}
