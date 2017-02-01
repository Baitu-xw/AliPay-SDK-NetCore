using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     CityFunction Data Structure.
    /// </summary>
    [Serializable]
    public class CityFunction : AopObject
    {
        /// <summary>
        ///     城市标准编码
        /// </summary>
        [XmlElement("city_code")]
        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        /// <summary>
        ///     城市名称
        /// </summary>
        [XmlElement("city_name")]
        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CityName { get; set; }

        /// <summary>
        ///     描述功能，支持开卡(issue)，圈存(load)，充值转账(recharge)
        /// </summary>
        [XmlArray("function_type")]
        [XmlArrayItem("string")]
        public List<string> FunctionType { get; set; }
    }
}