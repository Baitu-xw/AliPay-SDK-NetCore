using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemGoodsList : AopObject
    {
        /// <summary>
        ///     外部单品的描述信息（此字段暂时无用）
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        ///     外部单品id列表，传入服务商、商户系统中的商品id。
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }
    }
}