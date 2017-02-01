using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCard Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCard : AopObject
    {
        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("balance")]
		[JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 支付宝业务卡号  说明：  1、开卡成功后返回该参数，需要保存留用；  2、开卡/更新/删卡/查询卡接口请求中不需要传该参数；
        /// </summary>
        [XmlElement("biz_card_no")]
		[JsonProperty("biz_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户外部会员卡卡号  说明：  1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；  2、更新、查询、删除等接口，请求中则不需要提供该参数值；
        /// </summary>
        [XmlElement("external_card_no")]
		[JsonProperty("external_card_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）
        /// </summary>
        [XmlElement("level")]
		[JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("open_date")]
		[JsonProperty("open_date", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenDate { get; set; }

        /// <summary>
        /// 会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）
        /// </summary>
        [XmlElement("point")]
		[JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public string Point { get; set; }

        /// <summary>
        /// 会员卡有效期
        /// </summary>
        [XmlElement("valid_date")]
		[JsonProperty("valid_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidDate { get; set; }
    }
}
