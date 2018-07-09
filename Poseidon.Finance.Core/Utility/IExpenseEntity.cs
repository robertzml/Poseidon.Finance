using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.Utility
{
    /// <summary>
    /// 用款对象接口
    /// </summary>
    public interface IExpenseEntity
    {
        /// <summary>
        /// 用款ID
        /// </summary>
        [Display(Name = "用款ID")]
        List<string> ExpenseIds { get; set; }
    }
}
