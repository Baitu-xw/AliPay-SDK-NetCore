using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayDataItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataItemGoodsList : AopObject
    {
        /// <summary>
        ///     单品的描述信息
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        ///     单品id列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }
    }
}