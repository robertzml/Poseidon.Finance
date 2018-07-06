using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 用款数据访问接口
    /// </summary>
    internal interface IExpenseRepository : IBaseDAL<Expense>
    {
    }
}
