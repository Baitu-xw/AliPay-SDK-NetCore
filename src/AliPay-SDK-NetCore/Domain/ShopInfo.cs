using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     ShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopInfo : AopObject
    {
        /// <summary>
        ///     企业门店名称
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }

        /// <summary>
        ///     店铺内景图片，如要签约当面付产品，需上传3张店铺内景图片
        /// </summary>
        [XmlArray("shop_scene_pic")]
        [XmlArrayItem("string")]
        public List<string> ShopScenePic { get; set; }

        /// <summary>
        ///     店铺门头照图片
        /// </summary>
        [XmlElement("shop_sign_board_pic")]
        [JsonProperty("shop_sign_board_pic", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopSignBoardPic { get; set; }
    }
}