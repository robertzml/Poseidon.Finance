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
    /// 经费本数据访问类
    /// </summary>
    internal class FundRepository : AbstractDALMongo<Fund>, IFundRepository
    {
        #region Field
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 经费本数据访问类
        /// </summary>
        public FundRepository()
        {
            base.Init("finance_fund");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Fund DocToEntity(BsonDocument doc)
        {
            Fund entity = new Fund();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Number = doc["number"].ToString();
            entity.Principal = doc["principal"].ToString();
            entity.Balance = doc["balance"].ToDecimal();
            entity.AvailableBalance = doc["availableBalance"].ToDecimal();
            entity.DatasetCode = doc["datasetCode"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Fund entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "number", entity.Number },
                { "principal", entity.Principal },
                { "balance", entity.Balance },
                { "availableBalance", entity.AvailableBalance },
                { "datasetCode", entity.DatasetCode },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
