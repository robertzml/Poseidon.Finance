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
            entity.FundId = doc["fundId"].ToString();
            entity.FundName = doc["fundName"].ToString();
            entity.FundNumber = doc["fundNumber"].ToString();
            entity.Summary = doc["summary"].ToString();
            entity.Amount = doc["amount"].ToDecimal();
            entity.Operator = doc["operator"].ToString();
            entity.ExpenseDate = doc["expenseDate"].ToLocalTime();
            entity.IsWriteOff = doc["isWriteOff"].ToBoolean();
            entity.Module = doc["module"].ToString();
            entity.EntityId = doc["entityId"].ToString();

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
                { "fundId", entity.FundId },
                { "fundName", entity.FundName },
                { "fundNumber", entity.FundNumber },
                { "summary", entity.Summary },
                { "amount", entity.Amount },
                { "operator", entity.Operator },
                { "expenseDate", entity.ExpenseDate },
                { "isWriteOff", entity.IsWriteOff },
                { "module", entity.Module },
                { "entityId", entity.Id },
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
    }
}
