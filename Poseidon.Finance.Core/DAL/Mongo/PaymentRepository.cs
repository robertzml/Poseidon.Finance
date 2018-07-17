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
    /// 付款数据访问类
    /// </summary>
    internal class PaymentRepository : AbstractDALMongo<Payment>, IPaymentRepository
    {
        #region Constructor
        /// <summary>
        /// 付款数据访问类
        /// </summary>
        public PaymentRepository()
        {
            base.Init("finance_payment");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Payment DocToEntity(BsonDocument doc)
        {
            Payment entity = new Payment();
            entity.Id = doc["_id"].ToString();
            entity.SerialNumber = doc["serialNumber"].ToString();
            entity.FundId = doc["fundId"].ToString();
            entity.FundName = doc["fundName"].ToString();
            entity.FundNumber = doc["fundNumber"].ToString();
            entity.Summary = doc["summary"].ToString();
            entity.SumFee = doc["sumFee"].ToDecimal();
            entity.Discount = doc["discount"].ToDecimal();
            entity.Remission = doc["remission"].ToDecimal();
            entity.PaidFee = doc["paidFee"].ToDecimal();
            entity.PaidDate = doc["paidDate"].ToLocalTime();
            entity.IsPost = doc["isPost"].ToBoolean();

            entity.ExpenseIds = new List<string>();
            if (doc.Contains("expenseIds"))
            {
                BsonArray array = doc["expenseIds"].AsBsonArray;
                foreach (string item in array)
                {
                    entity.ExpenseIds.Add(item);
                }
            }

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
        protected override BsonDocument EntityToDoc(Payment entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "serialNumber", entity.SerialNumber },
                { "fundId", entity.FundId },
                { "fundName", entity.FundName },
                { "fundNumber", entity.FundNumber },
                { "summary", entity.Summary },
                { "sumFee", entity.SumFee },
                { "discount", entity.Discount },
                { "remission", entity.Remission },
                { "paidFee", entity.PaidFee },
                { "paidDate", entity.PaidDate },
                { "isPost", entity.IsPost },
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

            if (entity.ExpenseIds != null && entity.ExpenseIds.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.ExpenseIds)
                {
                    array.Add(item);
                }

                doc.Add("expenseIds", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加付款信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override Payment Create(Payment entity)
        {
            entity.SerialNumber = this.GenerateSerialNumber(DateTime.Now);
            return base.Create(entity);
        }
        #endregion //Method
    }
}
