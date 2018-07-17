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
    /// 付款业务类
    /// </summary>
    public class PaymentBusiness : AbstractBusiness<Payment>, IBaseBL<Payment>
    {
        #region Constructor
        /// <summary>
        /// 付款业务类
        /// </summary>
        public PaymentBusiness()
        {
            this.baseDal = RepositoryFactory<IPaymentRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 添加付款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Payment entity, LoginUser user)
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

            entity.IsPost = false;
            entity.Status = 0;
            base.Create(entity);
        }
        #endregion //Method
    }
}
