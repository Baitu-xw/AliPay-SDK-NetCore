using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayPassTemplateAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassTemplateAddModel : AopObject
    {
        /// <summary>
        ///     模板内容信息，遵循JSON规范，详情参见
        ///     <a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=193&articleId=105249&docType=1#tpl_content">tpl_content参数说明</a>
        /// </summary>
        [XmlElement("tpl_content")]
        [JsonProperty("tpl_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TplContent { get; set; }

        /// <summary>
        ///     商户用于控制模版的唯一性。（可以使用时间戳保证唯一性）
        /// </summary>
        [XmlElement("unique_id")]
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }
    }
}