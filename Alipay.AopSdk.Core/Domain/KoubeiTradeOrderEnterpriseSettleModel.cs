using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiTradeOrderEnterpriseSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderEnterpriseSettleModel : AopObject
    {
        /// <summary>
        /// 业务产品
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 买家支付金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("buyer_amount")]
        public string BuyerAmount { get; set; }

        /// <summary>
        /// 买家个人账户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家个人账户类型，buyer_type=alipay时，buyer_id代表买家的支付宝uid，会对buyer_id做合法性校验    alipay  支付宝账号  mobile   手机号  outUser  外部用户账号
        /// </summary>
        [XmlElement("buyer_type")]
        public string BuyerType { get; set; }

        /// <summary>
        /// 第三方企业支付的金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("enterprise_amount")]
        public string EnterpriseAmount { get; set; }

        /// <summary>
        /// 额外的业务信息，以json串的格式传入，传入企业信息(enterpriseInfo)，是否支持开票(supportInvoice)，可开票金额(invoiceAmount)等信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商家补贴金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 外部平台补贴的金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元，精确到小数点后两位  商家实收金额 = 平台优惠金额+企业支付金额+买家支付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位。  订单总金额=商家实收金额+商家优惠金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 该笔订单交易关闭超时时间，逾期将关闭交易，取值范围:3m～60m(单位:分钟) 不传默认3m。
        /// </summary>
        [XmlElement("trade_close_timeout")]
        public string TradeCloseTimeout { get; set; }

        /// <summary>
        /// 该笔订单的交易完结超时时间，从结算成功开始计算，逾期将把交易状态推进到完结，完结后不允许退款，取值范围:1m～3000m(单位:分钟) 不传默认2880m(48小时)。
        /// </summary>
        [XmlElement("trade_finish_timeout")]
        public string TradeFinishTimeout { get; set; }
    }
}
