using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEcoMycarParkingExitinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingExitinfoSyncModel : AopObject
    {
        /// <summary>
        ///     车牌号
        /// </summary>
        [XmlElement("car_number")]
        [JsonProperty("car_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CarNumber { get; set; }

        /// <summary>
        ///     车辆离场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("out_time")]
        [JsonProperty("out_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTime { get; set; }

        /// <summary>
        ///     支付宝停车场ID，系统唯一
        /// </summary>
        [XmlElement("parking_id")]
        [JsonProperty("parking_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParkingId { get; set; }
    }
}