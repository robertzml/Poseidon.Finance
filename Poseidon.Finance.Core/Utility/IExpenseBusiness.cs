using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.Utility
{
    /// <summary>
    /// 费用业务接口
    /// </summary>
    /// <remarks>
    /// 包含费用的信息，其业务类继承该接口
    /// </remarks>
    public interface IExpenseBusiness
    {
        /// <summary>
        /// 增加费用对象后执行
        /// </summary>
        /// <param name="expenseId">新费用ID</param>
        /// <param name="documentId">关联文档ID</param>
        void AfterCreate(string expenseId, string documentId);
    }
}
