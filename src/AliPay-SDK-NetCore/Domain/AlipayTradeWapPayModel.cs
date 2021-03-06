using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayTradeWapPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeWapPayModel : AopObject
    {
        /// <summary>
        ///     针对用户授权接口，获取用户相关数据时，用于标识用户授权关系
        /// </summary>
        [XmlElement("auth_token")]
        [JsonProperty("auth_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthToken { get; set; }

        /// <summary>
        ///     Iphone6 16G
        /// </summary>
        [XmlElement("body")]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        ///     禁用渠道，用户不可用指定渠道支付  当有多个渠道时用“,”分隔  注，与enable_pay_channels互斥
        /// </summary>
        [XmlElement("disable_pay_channels")]
        [JsonProperty("disable_pay_channels", NullValueHandling = NullValueHandling.Ignore)]
        public string DisablePayChannels { get; set; }

        /// <summary>
        ///     可用渠道，用户只能在指定渠道范围内支付  当有多个渠道时用“,”分隔  注，与disable_pay_channels互斥
        /// </summary>
        [XmlElement("enable_pay_channels")]
        [JsonProperty("enable_pay_channels", NullValueHandling = NullValueHandling.Ignore)]
        public string EnablePayChannels { get; set; }

        /// <summary>
        ///     业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        ///     商品主类型 :0-虚拟类商品,1-实物类商品
        /// </summary>
        [XmlElement("goods_type")]
        [JsonProperty("goods_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsType { get; set; }

        /// <summary>
        ///     商户网站唯一订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     公用回传参数，如果请求时传递了该参数，则返回给商户时会回传该参数。支付宝只会在同步返回（包括跳转回商户网站）和异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [XmlElement("passback_params")]
        [JsonProperty("passback_params", NullValueHandling = NullValueHandling.Ignore)]
        public string PassbackParams { get; set; }

        /// <summary>
        ///     销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [XmlElement("product_code")]
        [JsonProperty("product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        ///     优惠参数  注：仅与支付宝协商后可用
        /// </summary>
        [XmlElement("promo_params")]
        [JsonProperty("promo_params", NullValueHandling = NullValueHandling.Ignore)]
        public string PromoParams { get; set; }

        /// <summary>
        ///     用户付款中途退出返回商户网站的地址
        /// </summary>
        [XmlElement("quit_url")]
        [JsonProperty("quit_url", NullValueHandling = NullValueHandling.Ignore)]
        public string QuitUrl { get; set; }

        /// <summary>
        ///     描述分账信息，Json格式，详见分账参数说明
        /// </summary>
        [XmlElement("royalty_info")]
        [JsonProperty("royalty_info", NullValueHandling = NullValueHandling.Ignore)]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        ///     收款支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [XmlElement("seller_id")]
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        ///     商户门店编号
        /// </summary>
        [XmlElement("store_id")]
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        ///     商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [XmlElement("subject")]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        ///     绝对超时时间，格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [XmlElement("time_expire")]
        [JsonProperty("time_expire", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeExpire { get; set; }

        /// <summary>
        ///     该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [XmlElement("timeout_express")]
        [JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        ///     订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
    }
}