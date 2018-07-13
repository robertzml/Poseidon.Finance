using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Finance.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Finance.Core.IDAL;

    /// <summary>
    /// 用款数据访问类
    /// </summary>
    internal class ExpenseRepository : AbstractDALMongo<Expense>, IExpenseRepository
    {
        #region Constructor
        /// <summary>
        /// 用款数据访问类
        /// </summary>
        public ExpenseRepository()
        {
            base.Init("finance_expense");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Expense DocToEntity(BsonDocument doc)
        {
            Expense entity = new Expense();
            entity.Id = doc["_id"].ToString();
            entity.SerialNumber = doc["serialNumber"].ToString();
            entity.Summary = doc["summary"].ToString();
            entity.Amount = doc["amount"].ToDecimal();
            entity.CategoryNumber = doc["categoryNumber"].ToString();
            entity.CategoryName = doc["categoryName"].ToString();
            entity.Operator = doc["operator"].ToString();
            entity.ExpenseDate = doc["expenseDate"].ToLocalTime();
            entity.IsPaid = doc["isPaid"].ToBoolean();
            entity.ModuleName = doc["moduleName"].ToString();
            entity.AssemblyName = doc["assemblyName"].ToString();
            entity.CollectionName = doc["collectionName"].ToString();
            entity.DocumentId = doc["documentId"].ToString();

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            var updateBy = doc["updateBy"].ToBsonDocument();
            entity.UpdateBy = new UpdateStamp
            {
                UserId = updateBy["userId"].ToString(),
                Name = updateBy["name"].ToString(),
                Time = updateBy["time"].ToLocalTime()
            };

            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Expense entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "serialNumber", entity.SerialNumber },
                { "summary", entity.Summary },
                { "amount", entity.Amount },
                { "categoryNumber", entity.CategoryNumber },
                { "categoryName", entity.CategoryName },
                { "operator", entity.Operator },
                { "expenseDate", entity.ExpenseDate },
                { "isPaid", entity.IsPaid },
                { "moduleName", entity.ModuleName },
                { "assemblyName", entity.AssemblyName },
                { "collectionName", entity.CollectionName },
                { "documentId", entity.DocumentId },
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "updateBy", new BsonDocument {
                    { "userId", entity.UpdateBy.UserId },
                    { "name", entity.UpdateBy.Name },
                    { "time", entity.UpdateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加用款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override Expense Create(Expense entity)
        {
            entity.SerialNumber = this.GenerateSerialNumber(DateTime.Now);
            return base.Create(entity);
        }
        #endregion //Method
    }
}
