using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.Utility
{
    /// <summary>
    /// 费用对象接口
    /// </summary>
    public interface IExpenseEntity
    {
        /// <summary>
        /// 费用ID
        /// </summary>
        [Display(Name = "费用ID")]
        List<string> ExpenseIds { get; set; }
    }
}
