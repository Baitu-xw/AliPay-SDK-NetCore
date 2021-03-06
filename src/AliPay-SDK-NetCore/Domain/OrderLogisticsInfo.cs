using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     OrderLogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInfo : AopObject
    {
        /// <summary>
        ///     消费者下单线下服务时，填写的服务地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        ///     联系人
        /// </summary>
        [XmlElement("contact_name")]
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        ///     订单的物流扩展信息，包括服务开始时间、服务结束时间
        /// </summary>
        [XmlElement("ext_info")]
        [JsonProperty("ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public OrderLogisticsExtInfo ExtInfo { get; set; }

        /// <summary>
        ///     消费者地址维度（高德坐标系）
        /// </summary>
        [XmlElement("latitude")]
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        /// <summary>
        ///     消费者地址经度（高德坐标系）
        /// </summary>
        [XmlElement("longitude")]
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        /// <summary>
        ///     联系电话
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }
    }
}