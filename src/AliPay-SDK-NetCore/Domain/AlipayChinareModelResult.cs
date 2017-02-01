using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayChinareModelResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayChinareModelResult : AopObject
    {
        /// <summary>
        /// 体检记录id
        /// </summary>
        [XmlElement("id")]
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
		[JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 核保结果
        /// </summary>
        [XmlElement("rule_result")]
		[JsonProperty("rule_result", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleResult { get; set; }

        /// <summary>
        /// 交易流水记录id
        /// </summary>
        [XmlElement("trans_id")]
		[JsonProperty("trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransId { get; set; }
    }
}
