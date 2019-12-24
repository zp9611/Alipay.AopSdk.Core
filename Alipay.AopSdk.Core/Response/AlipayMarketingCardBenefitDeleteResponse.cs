using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitDeleteResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitDeleteResponse : AopResponse
    {
        /// <summary>
        /// 权益删除结果；true成功，false失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
