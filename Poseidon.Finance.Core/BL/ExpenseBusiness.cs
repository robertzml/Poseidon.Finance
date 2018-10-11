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
    /// 费用业务类
    /// </summary>
    public class ExpenseBusiness : AbstractBusiness<Expense>, IBaseBL<Expense>
    {
        #region Constructor
        /// <summary>
        /// 费用业务类
        /// </summary>
        public ExpenseBusiness()
        {
            this.baseDal = RepositoryFactory<IExpenseRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有未付费用记录
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Expense> FindUnPaid()
        {
            return this.baseDal.FindListByField("isPaid", false);
        }

        /// <summary>
        /// 按文档ID获取费用记录
        /// </summary>
        /// <param name="documentId">文档ID</param>
        /// <returns></returns>
        public IEnumerable<Expense> FindByDocumentId(string documentId)
        {
            return this.baseDal.FindListByField("documentId", documentId);
        }

        /// <summary>
        /// 费用记录付款
        /// </summary>
        /// <param name="id">费用ID</param>
        /// <param name="paid">是否支付</param>
        /// <returns></returns>
        public bool PayExpense(string id, bool paid = true)
        {
            var entity = this.baseDal.FindById(id);
            entity.IsPaid = paid;

            var result = this.baseDal.Update(entity);
            return result.success;
        }

        /// <summary>
        /// 添加费用信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Expense entity, ILoginUser user)
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

            entity.PaidFee = 0;
            entity.IsPaid = false;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑费用信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Expense entity, ILoginUser user)
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
