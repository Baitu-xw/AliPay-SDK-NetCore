using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     ZhimaCustomerCertificationCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationCertifyResponse : AopResponse
    {
        /// <summary>
        ///     一次认证的唯一标识,在商户调用认证初始化接口的时候获取,认证完成返回的biz_no和请求的一致
        /// </summary>
        [XmlElement("biz_no")]
        [JsonProperty("biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BizNo { get; set; }

        /// <summary>
        ///     如果认证没有通过会显示失败原因,如果需要详细的失败原因请使用认证查询接口
        /// </summary>
        [XmlElement("failed_reason")]
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        ///     认证是否通过,通过为true,不通过为false
        /// </summary>
        [XmlElement("passed")]
        [JsonProperty("passed", NullValueHandling = NullValueHandling.Ignore)]
        public string Passed { get; set; }
    }
}