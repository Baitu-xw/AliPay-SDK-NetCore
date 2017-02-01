using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMemberCouponQuerylistResponse.
    /// </summary>
    public class AlipayMemberCouponQuerylistResponse : AopResponse
    {
        /// <summary>
        ///     券信息数组.  如果没有查询到券信息，则为数组长度为0。  否则返回券信息数组
        /// </summary>
        [XmlArray("coupon_list")]
        [XmlArrayItem("coupon")]
        public List<Coupon> CouponList { get; set; }

        /// <summary>
        ///     请求成功时，不存在本参数；  请求失败时，本参数为错误代码，参见“7  错误码”。
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
        ///     本轮查询返回的数量
        /// </summary>
        [XmlElement("list_size")]
        [JsonProperty("list_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ListSize { get; set; }

        /// <summary>
        ///     整个业务处理成功时  返回T否则返回F。  具体的错误码和 信息科参考error_code和error_msg信息
        /// </summary>
        [XmlElement("success_code")]
        [JsonProperty("success_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessCode { get; set; }

        /// <summary>
        ///     总记录数
        /// </summary>
        [XmlElement("total_num")]
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalNum { get; set; }
    }
}