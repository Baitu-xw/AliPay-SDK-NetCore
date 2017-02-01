using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoCplifeBasicserviceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeBasicserviceInitializeModel : AopObject
    {
        /// <summary>
        ///     若服务类型为物业缴费账单模式，每个小区默认的收款帐号为授权物业的支付宝账号，默认不用传该参数。
        ///     但为满足部分物业个性化需求，允许开发者为每个小区服务传入一个指定的物业收款帐号。根据不同账号类型，开发者需要向物业或支付宝商务支持接口人获取具体的收款帐号。
        /// </summary>
        [XmlElement("account")]
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        ///     若服务类型为物业缴费账单模式，每个小区默认的收款帐号为授权物业的支付宝账号，默认不用传该参数。  但允许开发者为每个小区服务传入一个指定的物业收款帐号，收款帐号支持三种类型：    ALIPAY_LOGON_ID -
        ///     物业签约支付宝收单产品时配置的支付宝收款限制集中的支付宝登陆账号，必须在授权物业账号名下的收款限制集中。    ALIPAY_PARTNER_ID -
        ///     物业签约支付宝收单产品时配置的支付宝收款限制集中的账号PID，2088开头的16位账号。必须在授权物业账号名下的收款限制集中。    BANK_CARD_ID -
        ///     物业集团公司在签约收单产品时支付宝平台配置的银行卡编号（注：非实际银行账号）。
        /// </summary>
        [XmlElement("account_type")]
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountType { get; set; }

        /// <summary>
        ///     支付宝社区小区统一编号，必须在物业账号名下存在。
        /// </summary>
        [XmlElement("community_id")]
        [JsonProperty("community_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommunityId { get; set; }

        /// <summary>
        ///     由开发者系统提供的，支付宝根据基础服务类型在特定业务环节调用的外部系统服务地址，开发者需要确保外部地址的准确性。在线上环境需要使用HTTPS协议，会检查ssl证书，要求证书为正规的证书机构签发，不支持自签名证书。
        ///     对于PROPERTY_PAY_BILL_MODE服务类型，该地址表示用户缴费支付完成后开发者系统接受支付结果通知的回调地址。
        /// </summary>
        [XmlElement("external_invoke_address")]
        [JsonProperty("external_invoke_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalInvokeAddress { get; set; }

        /// <summary>
        ///     若本服务有预期的过期时间（如在物业服务合同中约定），开发者按标准时间格式：yyyy-MM-dd HH:mm:ss传入。
        /// </summary>
        [XmlElement("service_expires")]
        [JsonProperty("service_expires", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceExpires { get; set; }

        /// <summary>
        ///     基础服务类型，目前支持的类型值为：  PROPERTY_PAY_BILL_MODE - 物业缴费账单上传模式
        /// </summary>
        [XmlElement("service_type")]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }
    }
}