using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertPreserveCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertPreserveCommissionClause : AopObject
    {
        /// <summary>
        /// user_id：支付宝账户ID(2088开头)  logon_id：登陆账号
        /// </summary>
        [XmlElement("claimer_id_type")]
		[JsonProperty("claimer_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimerIdType { get; set; }

        /// <summary>
        /// 认领人
        /// </summary>
        [XmlArray("claimers")]
        [XmlArrayItem("string")]
        public List<string> Claimers { get; set; }
    }
}
