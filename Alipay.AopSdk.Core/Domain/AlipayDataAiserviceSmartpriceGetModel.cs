using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceSmartpriceGetModel : AopObject
    {
        /// <summary>
        /// 兼容V1.0。月卡售卖原价，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 用户购买hellobike月卡的渠道，目前有两种：alipay_tinyapp:小程序, hellobike_app:hellobike客户端，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码，国标码，hellobike定位到的用户当前所在城市，该参数由hellobike调用方定位用户当前所在城市得到。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 价格限定条件，用于不同优惠卡之间的价格不等式约束
        /// </summary>
        [XmlArray("conditions")]
        [XmlArrayItem("hello_bike_price_condition")]
        public List<HelloBikePriceCondition> Conditions { get; set; }

        /// <summary>
        /// 请求约束条件，用于约束优惠卡的出价区间等信息
        /// </summary>
        [XmlArray("constraints")]
        [XmlArrayItem("hello_bike_price_constraint")]
        public List<HelloBikePriceConstraint> Constraints { get; set; }

        /// <summary>
        /// 兼容V1.0。用户参与月卡打折活动时，默认的折扣价格，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 活动页面来源，即用户跳转到活动页面的前一个页面。CARD:月卡购买页面跳转，OTHER：其他场景页面跳转，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("from")]
        public string From { get; set; }

        /// <summary>
        /// 兼容V1.0。月卡售价区间范围的上限，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 兼容V1.0。月卡售价区间范围的下限，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [XmlElement("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 场景码，目前用于区分「单车」和「电单车」两种场景，其中，单车对应 bike， 电单车对应 ebike。不传该字段，默认为单车。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户参与一次月卡打折活动的业务标识，需要唯一。通过该业务标识串联用户在一次月卡打折活动中的涉及的关键业务流程（调用alipay.data.aiservice.smartprice.get接口获取用户购买月卡的活动价格、领取折扣券、购买月卡3个业务流程），该参数由hellobike业务端生成该id并在上述3个业务流程推进过程中存储记录该id。
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，作为用户标识，该参数可通过alipay.user.info.share接口获取。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
