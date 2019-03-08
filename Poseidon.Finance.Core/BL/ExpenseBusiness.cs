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
        /// 获取所有未绑定费用记录
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Expense> FindUnBind()
        {
            return this.baseDal.FindListByField("documentId", "");
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
        /// 按年度获取付款记录
        /// </summary>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Expense> FindByYear(int year)
        {
            return this.baseDal.FindAll().Where(r => r.ExpenseDate.Year == year);
        }

        /// <summary>
        /// 费用记录付款
        /// </summary>
        /// <param name="id">费用ID</param>
        /// <param name="paidFee">支付费用</param>
        /// <returns></returns>
        public bool PayExpense(string id, decimal paidFee)
        {
            var entity = this.baseDal.FindById(id);

            entity.PaidFee += paidFee;

            if (entity.Amount < entity.PaidFee)
                return false;

            if (entity.Amount == entity.PaidFee)
                entity.IsPaid = true;

            var result = this.baseDal.Update(entity);
            return result.success;
        }

        /// <summary>
        /// 撤回费用记录付款
        /// </summary>
        /// <param name="id">费用ID</param>
        /// <param name="paidFee">支付费用</param>
        /// <returns></returns>
        public bool UnpayExpense(string id, decimal paidFee)
        {
            var entity = this.baseDal.FindById(id);
            entity.PaidFee -= paidFee;
            entity.IsPaid = false;

            var result = this.baseDal.Update(entity);
            return result.success;
        }

        /// <summary>
        /// 绑定费用记录到业务对象
        /// </summary>
        /// <param name="id">费用ID</param>
        /// <param name="moduleName">模块名称</param>
        /// <param name="assemblyName">程序集名称</param>
        /// <param name="collectionName">集合名称</param>
        /// <param name="documentId">文档ID</param>
        /// <returns></returns>
        public (bool success, string errorMessage) BindExpense(string id, string moduleName, string assemblyName, string collectionName, string documentId)
        {
            var entity = this.baseDal.FindById(id);

            if (string.IsNullOrEmpty(entity.DocumentId))
            {

                entity.ModuleName = moduleName;
                entity.AssemblyName = assemblyName;
                entity.CollectionName = collectionName;
                entity.DocumentId = documentId;

                var result = this.baseDal.Update(entity);
                return result;
            }
            else
                return (false, "该费用记录包含业务对象");
        }
        #endregion //Method

        #region CRUD
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

        /// <summary>
        /// 删除费用记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override (bool success, string errorMessage) Delete(Expense entity)
        {
            PaymentBusiness paymentBusiness = new PaymentBusiness();
            var records = paymentBusiness.GetPaymentRecordsByExpense(entity.Id);
            if (records.Count > 0)
            {
                return (false, "存在付款记录");
            }

            return base.Delete(entity);
        }
        #endregion //CRUD
    }
}
