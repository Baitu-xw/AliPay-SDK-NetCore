using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayTradePayResponse.
    /// </summary>
    public class AlipayTradePayResponse : AopResponse
    {
        /// <summary>
        ///     买家支付宝账号
        /// </summary>
        [XmlElement("buyer_logon_id")]
        [JsonProperty("buyer_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerLogonId { get; set; }

        /// <summary>
        ///     买家付款的金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        [JsonProperty("buyer_pay_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        ///     买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_user_id")]
        [JsonProperty("buyer_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerUserId { get; set; }

        /// <summary>
        ///     支付宝卡余额
        /// </summary>
        [XmlElement("card_balance")]
        [JsonProperty("card_balance", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBalance { get; set; }

        /// <summary>
        ///     本次交易支付所使用的单品券优惠的商品优惠信息
        /// </summary>
        [XmlElement("discount_goods_detail")]
        [JsonProperty("discount_goods_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        ///     交易支付使用的资金渠道
        /// </summary>
        [XmlArray("fund_bill_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        ///     交易支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        [JsonProperty("gmt_payment", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtPayment { get; set; }

        /// <summary>
        ///     交易中可给用户开具发票的金额
        /// </summary>
        [XmlElement("invoice_amount")]
        [JsonProperty("invoice_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        ///     买家支付宝用户号,该参数已废弃，请不要使用。
        /// </summary>
        [XmlElement("open_id")]
        [JsonProperty("open_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenId { get; set; }

        /// <summary>
        ///     商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        ///     使用积分宝付款的金额
        /// </summary>
        [XmlElement("point_amount")]
        [JsonProperty("point_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PointAmount { get; set; }

        /// <summary>
        ///     实收金额
        /// </summary>
        [XmlElement("receipt_amount")]
        [JsonProperty("receipt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptAmount { get; set; }

        /// <summary>
        ///     发生支付交易的商户门店名称
        /// </summary>
        [XmlElement("store_name")]
        [JsonProperty("store_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreName { get; set; }

        /// <summary>
        ///     交易金额
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        ///     支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }

        /// <summary>
        ///     本交易支付时使用的所有优惠券信息
        /// </summary>
        [XmlArray("voucher_detail_list")]
        [XmlArrayItem("voucher_detail")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}