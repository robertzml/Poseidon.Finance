using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Finance.Core.IDAL;

    /// <summary>
    /// 用款业务类
    /// </summary>
    public class ExpenseBusiness : AbstractBusiness<Expense>, IBaseBL<Expense>
    {
        #region Constructor
        /// <summary>
        /// 用款业务类
        /// </summary>
        public ExpenseBusiness()
        {
            this.baseDal = RepositoryFactory<IExpenseRepository>.Instance;
        }
        #endregion //Constructor
    }
}
