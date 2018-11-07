using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.BL
{
    using MongoDB.Bson;
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
        /// 按年度获取付款记录
        /// </summary>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Payment> FindByYear(int year)
        {
            return this.baseDal.FindAll().Where(r => r.PaidDate.Year == year);
        }

        /// <summary>
        /// 撤回付款
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Revert(Payment entity)
        {
            ExpenseBusiness expenseBusiness = new ExpenseBusiness();

            foreach (var item in entity.Records)
            {
                expenseBusiness.UnpayExpense(item.ExpenseId, item.PaidFee);
            }

            return this.baseDal.Delete(entity);
        }
        #endregion //Method

        #region CRUD
        /// <summary>
        /// 添加付款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Payment entity, ILoginUser user)
        {
            ExpenseBusiness expenseBusiness = new ExpenseBusiness();

            foreach (var item in entity.Records)
            {
                item.PaymentId = "";
                expenseBusiness.PayExpense(item.ExpenseId, item.PaidFee);
            }

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

            foreach (var item in entity.Records)
            {
                item.PaymentId = entity.Id;
            }
            base.Update(entity);
        }

        /// <summary>
        /// 编辑付款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Payment entity, ILoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }
        #endregion //CRUD
    }
}
