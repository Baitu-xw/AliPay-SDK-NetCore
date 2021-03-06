using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMicropayOrderDirectPayResponse.
    /// </summary>
    public class AlipayMicropayOrderDirectPayResponse : AopResponse
    {
        /// <summary>
        ///     单笔直接支付返回结果
        /// </summary>
        [XmlElement("single_pay_detail")]
        [JsonProperty("single_pay_detail", NullValueHandling = NullValueHandling.Ignore)]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}