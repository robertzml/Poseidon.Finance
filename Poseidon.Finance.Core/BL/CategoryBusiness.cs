using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Finance.Core.IDAL;

    /// <summary>
    /// 费用分类业务类
    /// </summary>
    public class CategoryBusiness : AbstractBusiness<Category>, IBaseBL<Category>
    {
        #region Constructor
        /// <summary>
        /// 费用分类业务类
        /// </summary>
        public CategoryBusiness()
        {
            this.baseDal = RepositoryFactory<ICategoryRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有费用分类
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Category> FindAll()
        {
            return base.FindAll().OrderBy(r => r.Sort);
        }
        #endregion //Method
    }
}
