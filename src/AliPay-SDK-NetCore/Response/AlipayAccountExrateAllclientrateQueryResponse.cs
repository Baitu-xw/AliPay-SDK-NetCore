using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayAccountExrateAllclientrateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryResponse : AopResponse
    {
        /// <summary>
        ///     汇率信息列表
        /// </summary>
        [XmlArray("client_rate_list")]
        [XmlArrayItem("ex_client_rate_v_o")]
        public List<ExClientRateVO> ClientRateList { get; set; }
    }
}