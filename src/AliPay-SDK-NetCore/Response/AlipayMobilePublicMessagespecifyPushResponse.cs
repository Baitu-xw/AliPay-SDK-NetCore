using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMessagespecifyPushResponse.
    /// </summary>
    public class AlipayMobilePublicMessagespecifyPushResponse : AopResponse
    {
        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("msg")]
        public new string Msg { get; set; }
    }
}
