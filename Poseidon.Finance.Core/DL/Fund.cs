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
    /// 经费本类
    /// </summary>
    public class Fund : BaseEntity
    {
        #region Property
        /// <summary>
        /// 项目名称
        /// </summary>
        [Display(Name = "项目名称")]
        public string Name { get; set; }

        /// <summary>
        /// 项目号
        /// </summary>
        [Display(Name = "项目号")]
        public string Number { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [Display(Name = "负责人")]
        public string Principal { get; set; }

        /// <summary>
        /// 项目余额
        /// </summary>
        [Display(Name = "项目余额")]
        public decimal Balance { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [Display(Name = "可用余额")]
        public decimal AvailableBalance { get; set; }

        /// <summary>
        /// 数据集代码
        /// </summary>
        [Display(Name = "数据集代码")]
        public string DatasetCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }
        #endregion //Property
    }
}
