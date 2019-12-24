using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentShopConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentShopConsultResponse : AopResponse
    {
        /// <summary>
        /// 总共项数
        /// </summary>
        [XmlElement("items")]
        public string Items { get; set; }

        /// <summary>
        /// 智能营销方案符合标准的门店列表
        /// </summary>
        [XmlArray("shops")]
        [XmlArrayItem("intelligent_promo_shop_summary_info")]
        public List<IntelligentPromoShopSummaryInfo> Shops { get; set; }
    }
}
