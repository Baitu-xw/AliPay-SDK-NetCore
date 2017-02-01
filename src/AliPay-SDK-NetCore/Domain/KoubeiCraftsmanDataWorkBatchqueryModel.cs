using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiCraftsmanDataWorkBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCraftsmanDataWorkBatchqueryModel : AopObject
    {
        /// <summary>
        ///     服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；isv自身角色操作的时候，无需传该参数
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [XmlElement("craftsman_id")]
        [JsonProperty("craftsman_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CraftsmanId { get; set; }

        /// <summary>
        ///     页码，大于0，最大为int的最大值
        /// </summary>
        [XmlElement("page_no")]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PageNo { get; set; }

        /// <summary>
        ///     每页的条数，大于0，最大不超过100条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        ///     手艺人作品id列表，全局唯一，是创建手艺人作品接口koubei.craftsman.data.work.create返回的work_id
        /// </summary>
        [XmlArray("work_ids")]
        [XmlArrayItem("string")]
        public List<string> WorkIds { get; set; }
    }
}