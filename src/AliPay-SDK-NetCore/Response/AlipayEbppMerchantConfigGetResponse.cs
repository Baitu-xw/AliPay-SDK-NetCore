using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayEbppMerchantConfigGetResponse.
    /// </summary>
    public class AlipayEbppMerchantConfigGetResponse : AopResponse
    {
        /// <summary>
        ///     商户机构配置信息
        /// </summary>
        [XmlArray("inst_configs")]
        [XmlArrayItem("merchant_inst_config")]
        public List<MerchantInstConfig> InstConfigs { get; set; }

        /// <summary>
        ///     商户的用户ID
        /// </summary>
        [XmlElement("merchant_user_id")]
        [JsonProperty("merchant_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantUserId { get; set; }
    }
}