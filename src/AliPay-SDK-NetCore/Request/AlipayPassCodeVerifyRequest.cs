using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    ///     AOP API: alipay.pass.code.verify
    /// </summary>
    public class AlipayPassCodeVerifyRequest : IAopRequest<AlipayPassCodeVerifyResponse>
    {
        /// <summary>
        ///     商户核销操作扩展信息
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        ///     操作员id  如果operator_type为1，则此id代表核销人员id  如果operator_type为2，则此id代表核销机具id
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        ///     操作员类型  1 核销人员  2 核销机具
        /// </summary>
        public string OperatorType { get; set; }

        /// <summary>
        ///     Alipass对应的核销码串
        /// </summary>
        public string VerifyCode { get; set; }

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
            return "alipay.pass.code.verify";
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
            parameters.Add("ext_info", ExtInfo);
            parameters.Add("operator_id", OperatorId);
            parameters.Add("operator_type", OperatorType);
            parameters.Add("verify_code", VerifyCode);
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