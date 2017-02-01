using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCardUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardUpdateModel : AopObject
    {
        /// <summary>
        ///     需要修改的最新卡信息
        /// </summary>
        [XmlElement("card_info")]
        [JsonProperty("card_info", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        ///     扩展信息(暂时无用)
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtInfo { get; set; }

        /// <summary>
        ///     标识业务发生的时间
        /// </summary>
        [XmlElement("occur_time")]
        [JsonProperty("occur_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OccurTime { get; set; }

        /// <summary>
        ///     支付宝业务卡号，开卡接口中返回获取
        /// </summary>
        [XmlElement("target_card_no")]
        [JsonProperty("target_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCardNo { get; set; }

        /// <summary>
        ///     卡号ID类型  BIZ_CARD：支付宝业务卡号
        /// </summary>
        [XmlElement("target_card_no_type")]
        [JsonProperty("target_card_no_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCardNoType { get; set; }
    }
}