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
        /// 流水号
        /// </summary>
        [Display(Name = "流水号")]
        public string SerialNumber { get; set; }

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
        /// 分类号
        /// </summary>
        [Display(Name = "分类号")]
        public string CategoryNumber { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Display(Name = "分类名称")]
        public string CategoryName { get; set; }

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
        /// 是否支付
        /// </summary>
        [Display(Name = "是否支付")]
        public bool IsPaid { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [Display(Name = "模块名称")]
        public string ModuleName { get; set; }

        /// <summary>
        /// 程序集名称
        /// </summary>
        [Display(Name = "程序集名称")]
        public string AssemblyName { get; set; }

        /// <summary>
        /// 集合名称
        /// </summary>
        [Display(Name = "集合名称")]
        public string CollectionName { get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [Display(Name = "文档ID")]
        public string DocumentId { get; set; }
        #endregion //Property
    }
}
