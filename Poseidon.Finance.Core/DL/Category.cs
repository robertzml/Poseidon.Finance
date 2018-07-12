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
    /// 费用分类类
    /// </summary>
    public class Category : ObjectEntity
    {
        #region Property
        /// <summary>
        /// 分类号
        /// </summary>
        [Display(Name = "分类号")]
        public string Number { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        [Display(Name = "上级ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        [Display(Name = "排序码")]
        public int Sort { get; set; }
        #endregion //Property
    }
}
