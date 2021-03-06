using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMicropayOrderGetResponse.
    /// </summary>
    public class AlipayMicropayOrderGetResponse : AopResponse
    {
        /// <summary>
        ///     冻结订单详情
        /// </summary>
        [XmlElement("micro_pay_order_detail")]
        [JsonProperty("micro_pay_order_detail", NullValueHandling = NullValueHandling.Ignore)]
        public MicroPayOrderDetail MicroPayOrderDetail { get; set; }
    }
}