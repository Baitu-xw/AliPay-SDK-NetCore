using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMemberCardOpenResponse.
    /// </summary>
    public class AlipayMemberCardOpenResponse : AopResponse
    {
        /// <summary>
        ///     请求失败时，不存在本参数；  请求成功时，本参数不为空，json格式，目前仅支持如下key：  bizCardNo（支付宝会员卡卡号）。
        /// </summary>
        [XmlElement("card")]
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public string Card { get; set; }

        /// <summary>
        ///     请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error_code")]
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     请求成功时，不存在本参数；  请求失败时，本参数返回具体的错误原因。
        /// </summary>
        [XmlElement("error_msg")]
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        ///     请求是否成功。  T代表成功  F代表失败
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }
    }
}