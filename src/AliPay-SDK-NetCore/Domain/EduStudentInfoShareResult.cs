using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     EduStudentInfoShareResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduStudentInfoShareResult : AopObject
    {
        /// <summary>
        ///     教育分类
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     学生详细信息
        /// </summary>
        [XmlArray("student_infos")]
        [XmlArrayItem("student_info")]
        public List<StudentInfo> StudentInfos { get; set; }

        /// <summary>
        ///     用户的userid
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}