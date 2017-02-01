using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTokenAppQueryModel : AopObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [XmlElement("app_auth_token")]
		[JsonProperty("app_auth_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AppAuthToken { get; set; }
    }
}
