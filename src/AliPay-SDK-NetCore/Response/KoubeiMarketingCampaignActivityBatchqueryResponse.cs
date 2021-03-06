using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     KoubeiMarketingCampaignActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        ///     活动列表
        /// </summary>
        [XmlArray("camp_sets")]
        [XmlArrayItem("camp_base_dto")]
        public List<CampBaseDto> CampSets { get; set; }

        /// <summary>
        ///     总数量
        /// </summary>
        [XmlElement("total_number")]
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalNumber { get; set; }
    }
}