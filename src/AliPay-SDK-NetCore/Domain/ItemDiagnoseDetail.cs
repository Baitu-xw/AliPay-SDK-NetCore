using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ItemDiagnoseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDiagnoseDetail : AopObject
    {
        /// <summary>
        ///     菜品的热度等级 菜品热度等级（0/0.5/1/1.5/2/2.5/3/3.5/4/4.5/5）该字段是对热度值做离散化，方便用户用图像化表达热度
        /// </summary>
        [XmlElement("hot_grade")]
        [JsonProperty("hot_grade", NullValueHandling = NullValueHandling.Ignore)]
        public long HotGrade { get; set; }

        /// <summary>
        ///     菜品的热度值 保留两位小数，热度值在0~100分之间
        /// </summary>
        [XmlElement("hot_value")]
        [JsonProperty("hot_value", NullValueHandling = NullValueHandling.Ignore)]
        public long HotValue { get; set; }

        /// <summary>
        ///     菜品诊断 1-招牌菜品；2-中游菜品；3-潜力菜品；4-疑问菜品；5-其他菜品
        /// </summary>
        [XmlElement("item_diagnose")]
        [JsonProperty("item_diagnose", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDiagnose { get; set; }

        /// <summary>
        ///     诊断描述 招牌菜品：销量和复购多指标表现强劲，可力推该菜品；中游菜品：各指标表现适中；潜力菜品：高复购销量适中，可适当增加此类菜品推荐；疑问菜品：销量和复购表现差，需要对菜品进行优化
        /// </summary>
        [XmlElement("item_diagnose_desc")]
        [JsonProperty("item_diagnose_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDiagnoseDesc { get; set; }

        /// <summary>
        ///     外部商品ID
        /// </summary>
        [XmlElement("item_id")]
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        ///     菜品名称
        /// </summary>
        [XmlElement("item_name")]
        [JsonProperty("item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        /// <summary>
        ///     单位分
        /// </summary>
        [XmlElement("item_price")]
        [JsonProperty("item_price", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemPrice { get; set; }

        /// <summary>
        ///     近90天消费的支付宝用户数
        /// </summary>
        [XmlElement("rec_ninety_consume_uid_cnt")]
        [JsonProperty("rec_ninety_consume_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecNinetyConsumeUidCnt { get; set; }

        /// <summary>
        ///     近90天购买2次及以上的支付宝用户数
        /// </summary>
        [XmlElement("rec_ninety_rebuy_uid_cnt")]
        [JsonProperty("rec_ninety_rebuy_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecNinetyRebuyUidCnt { get; set; }

        /// <summary>
        ///     近7天的销售金额
        /// </summary>
        [XmlElement("rec_seven_sale_amt")]
        [JsonProperty("rec_seven_sale_amt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecSevenSaleAmt { get; set; }

        /// <summary>
        ///     近7天销售个数
        /// </summary>
        [XmlElement("rec_seven_sale_cnt")]
        [JsonProperty("rec_seven_sale_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecSevenSaleCnt { get; set; }

        /// <summary>
        ///     近60天消费的支付
        /// </summary>
        [XmlElement("rec_sixty_consume_uid_cnt")]
        [JsonProperty("rec_sixty_consume_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecSixtyConsumeUidCnt { get; set; }

        /// <summary>
        ///     近60天购买2次及以上的支付宝用户数
        /// </summary>
        [XmlElement("rec_sixty_rebuy_uid_cnt")]
        [JsonProperty("rec_sixty_rebuy_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecSixtyRebuyUidCnt { get; set; }

        /// <summary>
        ///     近30天消费的支付宝用户数
        /// </summary>
        [XmlElement("rec_thirty_consume_uid_cnt")]
        [JsonProperty("rec_thirty_consume_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public string RecThirtyConsumeUidCnt { get; set; }

        /// <summary>
        ///     近30天购买2次及以上的支付宝用户数
        /// </summary>
        [XmlElement("rec_thirty_rebuy_uid_cnt")]
        [JsonProperty("rec_thirty_rebuy_uid_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecThirtyRebuyUidCnt { get; set; }

        /// <summary>
        ///     近30天销售金额，单位分
        /// </summary>
        [XmlElement("rec_thirty_sale_amt")]
        [JsonProperty("rec_thirty_sale_amt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecThirtySaleAmt { get; set; }

        /// <summary>
        ///     近30天销售个数
        /// </summary>
        [XmlElement("rec_thirty_sale_cnt")]
        [JsonProperty("rec_thirty_sale_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public long RecThirtySaleCnt { get; set; }

        /// <summary>
        ///     报表数据生成日期 yyyyMMdd格式 保留最近30天数据
        /// </summary>
        [XmlElement("report_date")]
        [JsonProperty("report_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportDate { get; set; }
    }
}