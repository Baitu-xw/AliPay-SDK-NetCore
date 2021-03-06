using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayOfflineSaleleadsContractconfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsContractconfirmModel : AopObject
    {
        /// <summary>
        ///     支付宝名称
        /// </summary>
        [XmlElement("alipay_card_name")]
        [JsonProperty("alipay_card_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayCardName { get; set; }

        /// <summary>
        ///     商户支付宝账户,比如手机号邮箱等
        /// </summary>
        [XmlElement("alipay_card_no")]
        [JsonProperty("alipay_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayCardNo { get; set; }

        /// <summary>
        ///     需要签约确认的leads id
        /// </summary>
        [XmlElement("leads_id")]
        [JsonProperty("leads_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadsId { get; set; }

        /// <summary>
        ///     操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        [JsonProperty("ope_pid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpePid { get; set; }

        /// <summary>
        ///     全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        ///     签约状态，只能是“SIGN_SUCCESS”
        /// </summary>
        [XmlElement("sign_status")]
        [JsonProperty("sign_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SignStatus { get; set; }
    }
}