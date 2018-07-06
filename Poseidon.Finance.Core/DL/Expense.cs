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
    /// 用款类
    /// </summary>
    public class Expense : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 经办人
        /// </summary>
        [Display(Name = "经办人")]
        public string Operator { get; set; }

        /// <summary>
        /// 用款日期
        /// </summary>
        [Display(Name = "用款日期")]
        public DateTime ExpenseDate { get; set; }

        /// <summary>
        /// 是否核销
        /// </summary>
        [Display(Name = "是否核销")]
        public bool IsWriteOff { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        [Display(Name = "模块")]
        public string Module { get; set; }

        /// <summary>
        /// 关联对象ID
        /// </summary>
        [Display(Name = "关联对象ID")]
        public string EntityId { get; set; }
        #endregion //Property
    }
}
