using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingDataCustomreportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportQueryResponse : AopResponse
    {
        /// <summary>
        ///     数据量
        /// </summary>
        [XmlElement("count")]
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        ///     满足自定义报表规则的报表数据
        /// </summary>
        [XmlArray("report_data")]
        [XmlArrayItem("report_data_item")]
        public List<ReportDataItem> ReportData { get; set; }
    }
}