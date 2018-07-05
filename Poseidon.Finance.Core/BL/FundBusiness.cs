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
    /// 经费本业务类
    /// </summary>
    public class FundBusiness : AbstractBusiness<Fund>, IBaseBL<Fund>
    {
        #region Constructor
        /// <summary>
        /// 经费本业务类
        /// </summary>
        public FundBusiness()
        {
            this.baseDal = RepositoryFactory<IFundRepository>.Instance;
        }
        #endregion //Constructor
    }
}
