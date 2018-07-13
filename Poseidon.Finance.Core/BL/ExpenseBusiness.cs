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

        #region Method
        /// <summary>
        /// 添加用款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Expense entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            //entity.IsWriteOff = false;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑用款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Expense entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }
        #endregion //Method
    }
}
