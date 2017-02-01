using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayFundAuthOperationDetailQueryResponse.
    /// </summary>
    public class AlipayFundAuthOperationDetailQueryResponse : AopResponse
    {
        /// <summary>
        ///     该笔资金操作流水opertion_id对应的操作金额，单位为：元（人民币）
        /// </summary>
        [XmlElement("amount")]
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        ///     支付宝资金授权订单号
        /// </summary>
        [XmlElement("auth_no")]
        [JsonProperty("auth_no", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthNo { get; set; }

        /// <summary>
        ///     商户请求创建预授权订单时传入的扩展参数，仅返回商户自定义的扩展信息（merchantExt）
        /// </summary>
        [XmlElement("extra_param")]
        [JsonProperty("extra_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParam { get; set; }

        /// <summary>
        ///     资金授权单据操作流水创建时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_create")]
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        ///     支付宝账务处理成功时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_trans")]
        [JsonProperty("gmt_trans", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtTrans { get; set; }

        /// <summary>
        ///     支付宝资金操作流水号
        /// </summary>
        [XmlElement("operation_id")]
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }

        /// <summary>
        ///     支付宝资金操作类型，  目前支持：   FREEZE：冻结  UNFREEZE：解冻  PAY：支付
        /// </summary>
        [XmlElement("operation_type")]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        ///     业务订单的简单描述，如商品名称等
        /// </summary>
        [XmlElement("order_title")]
        [JsonProperty("order_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderTitle { get; set; }

        /// <summary>
        ///     商户的授权资金订单号
        /// </summary>
        [XmlElement("out_order_no")]
        [JsonProperty("out_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutOrderNo { get; set; }

        /// <summary>
        ///     商户资金操作的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        ///     付款方支付宝账号（Email或手机号），仅作展示使用，默认会加“*”号处理
        /// </summary>
        [XmlElement("payer_logon_id")]
        [JsonProperty("payer_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerLogonId { get; set; }

        /// <summary>
        ///     付款方支付宝账号对应的支付宝唯一用户号，以2088开头的16位纯数字组成
        /// </summary>
        [XmlElement("payer_user_id")]
        [JsonProperty("payer_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerUserId { get; set; }

        /// <summary>
        ///     商户对本次操作的附言描述，长度不超过100个字母或50个汉字
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        ///     订单总共剩余的冻结金额，单位为：元（人民币）
        /// </summary>
        [XmlElement("rest_amount")]
        [JsonProperty("rest_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RestAmount { get; set; }

        /// <summary>
        ///     资金操作流水的状态，  目前支持：   INIT：初始  SUCCESS：成功  CLOSED：关闭
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///     订单累计的冻结金额，单位为：元（人民币）
        /// </summary>
        [XmlElement("total_freeze_amount")]
        [JsonProperty("total_freeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFreezeAmount { get; set; }

        /// <summary>
        ///     订单累计用于支付的金额，单位为：元（人民币）
        /// </summary>
        [XmlElement("total_pay_amount")]
        [JsonProperty("total_pay_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPayAmount { get; set; }
    }
}