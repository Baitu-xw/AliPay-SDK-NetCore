using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    ///     AOP API: alipay.user.trade.search
    /// </summary>
    public class AlipayUserTradeSearchRequest : IAopRequest<AlipayUserTradeSearchResponse>
    {
        /// <summary>
        ///     支付宝订单号，为空查询所有记录
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     结束时间。与开始时间间隔在七天之内
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        ///     商户订单号，为空查询所有记录
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        ///     订单来源，为空查询所有来源。淘宝(TAOBAO)，支付宝(ALIPAY)，其它(OTHER)
        /// </summary>
        public string OrderFrom { get; set; }

        /// <summary>
        ///     订单状态，为空查询所有状态订单。例如：等待买家付款（WAIT_BUYER_PAY），等待卖家发货（WAIT_SELLER_SEND_GOODS），等待买家确认收货（WAIT_BUYER_CONFIRM_GOODS），交易完成（TRADE_FINISHED），交易关闭（TRADE_CLOSED），交易成功（TRADE_SUCCESS）
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        ///     订单类型，为空查询所有类型订单。例如：交易（TRADE）,CAE代扣（CAE）,代付（PEERPAY）,转账到卡（TRANSFER）
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        ///     页码。取值范围:大于零的整数; 默认值1
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        ///     每页获取条数。最大值500。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        ///     开始时间，时间必须是今天范围之内。格式为yyyy-MM-dd HH:mm:ss，精确到秒(升级后的api 1.1版本)
        /// </summary>
        public string StartTime { get; set; }

        #region IAopRequest Members

        private bool needEncrypt;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AopObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.user.trade.search";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AopDictionary();
            parameters.Add("alipay_order_no", AlipayOrderNo);
            parameters.Add("end_time", EndTime);
            parameters.Add("merchant_order_no", MerchantOrderNo);
            parameters.Add("order_from", OrderFrom);
            parameters.Add("order_status", OrderStatus);
            parameters.Add("order_type", OrderType);
            parameters.Add("page_no", PageNo);
            parameters.Add("page_size", PageSize);
            parameters.Add("start_time", StartTime);
            return parameters;
        }

        public AopObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}