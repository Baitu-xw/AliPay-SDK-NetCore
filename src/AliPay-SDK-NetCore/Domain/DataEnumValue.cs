using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataEnumValue Data Structure.
    /// </summary>
    [Serializable]
    public class DataEnumValue : AopObject
    {
        /// <summary>
        /// 过滤条件
        /// </summary>
        [XmlArray("filter_tags")]
        [XmlArrayItem("filter_tag")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 枚举的展示文本
        /// </summary>
        [XmlElement("label")]
		[JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 自定义标签的枚举值
        /// </summary>
        [XmlElement("value")]
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
