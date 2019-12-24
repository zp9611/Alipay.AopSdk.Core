using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetProduceItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetProduceItem : AopObject
    {
        /// <summary>
        /// 生产指令动作类别：套组则为ASSEMBLE，组装
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 申请日期，格式yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 收钱码吊牌和贴纸类型不为空;   物料图片Url，供应商使用该图片进行物料打印
        /// </summary>
        [XmlElement("asset_pic_url")]
        public string AssetPicUrl { get; set; }

        /// <summary>
        /// 目前只有空码生产的码图片url从这里获取
        /// </summary>
        [XmlElement("asset_resource")]
        public string AssetResource { get; set; }

        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 业务渠道
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 线下供应商区分业务流
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// city
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 订单创建时间, 格式: yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 1 - 旧模式, 需要在生产完成时反馈运单号 ; 2 - 新模式, 不需要在生产完成时反馈运单号
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 物流公司代码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 收钱码吊牌和贴纸类型不为空
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流运单号; 收钱码吊牌和贴纸类型不为空
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 生产指令描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 公司主体代码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [XmlElement("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 1. 如果该物料是套组的子物料, 那么该值为套组物料id; 2, 其他情况和物料id(即, item_id)一致或者为空.
        /// </summary>
        [XmlElement("parent_template_id")]
        public string ParentTemplateId { get; set; }

        /// <summary>
        /// 收件人地址邮编; 收钱码吊牌和贴纸类型不为空
        /// </summary>
        [XmlElement("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// 面单打印信息
        /// </summary>
        [XmlElement("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [XmlElement("produce_order")]
        public string ProduceOrder { get; set; }

        /// <summary>
        /// 生产模式类型，用于供应商区分业务是：直发生产还是备货生产
        /// </summary>
        [XmlElement("produce_type")]
        public string ProduceType { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 物料供应商PID，和调用方的供应商PID一致
        /// </summary>
        [XmlElement("supplier_pid")]
        public string SupplierPid { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称，线下约定的物料名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
