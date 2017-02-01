using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTradeCustomsDeclareResponse.
    /// </summary>
    public class AlipayTradeCustomsDeclareResponse : AopResponse
    {
        /// <summary>
        ///     支付宝报关流水号。
        /// </summary>
        [XmlElement("alipay_declare_no")]
        [JsonProperty("alipay_declare_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayDeclareNo { get; set; }

        /// <summary>
        ///     订购人身份信息和支付人的身份信息验证结果。T表示商户传入的订购人姓名和身份证号和支付人的姓名和身份证号一致。F代表商户传入的订购人姓名和身份证号和支付人的姓名和身份证号不一致。对于同一笔报关单支付宝只会校验一次，如果多次重推不会返回此参数。
        /// </summary>
        [XmlElement("identity_check")]
        [JsonProperty("identity_check", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityCheck { get; set; }

        /// <summary>
        ///     支付宝推送到海关的支付单据号。
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}