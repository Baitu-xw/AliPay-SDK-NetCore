using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOpenPublicLabelUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserQueryModel : AopObject
    {
        /// <summary>
        ///     支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}