using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayAcquirePrecreateResponse.
    /// </summary>
    public class AlipayAcquirePrecreateResponse : AopResponse
    {
        /// <summary>
        ///     详细错误码。对返回响应码进行原因说明  当result_code响应码为SUCCESS时，不返回该参数。
        /// </summary>
        [XmlElement("detail_error_code")]
        [JsonProperty("detail_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailErrorCode { get; set; }

        /// <summary>
        ///     对详细错误码进行文字说明  当result_code响应码为SUCCESS时，不返回该参数
        /// </summary>
        [XmlElement("detail_error_des")]
        [JsonProperty("detail_error_des", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailErrorDes { get; set; }

        /// <summary>
        ///     错误代码。  请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error")]
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        ///     请求是否成功。请求成功不代表业务处理成功  T代表成功  F代表失败
        /// </summary>
        [XmlElement("is_success")]
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSuccess { get; set; }

        /// <summary>
        ///     对应商户网站的订单系统中的唯一订单号，非支付宝交易号。  需保证在商户网站中的唯一性。是请求时对应的参数，原样返回
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     二维码图片的URL地址
        /// </summary>
        [XmlElement("pic_url")]
        [JsonProperty("pic_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PicUrl { get; set; }

        /// <summary>
        ///     二维码码串的内容
        /// </summary>
        [XmlElement("qr_code")]
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCode { get; set; }

        /// <summary>
        ///     预下单处理结果响应码。  SUCCESS：预下单成功  FAIL：预下单失败  UNKNOWN：结果未知
        /// </summary>
        [XmlElement("result_code")]
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        ///     支付宝交易号。该交易在支付宝系统中的交易流水号。  最短16位，最长64位
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }

        /// <summary>
        ///     凭证类型，目前仅支持qrcode（二维码）
        /// </summary>
        [XmlElement("voucher_type")]
        [JsonProperty("voucher_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VoucherType { get; set; }
    }
}