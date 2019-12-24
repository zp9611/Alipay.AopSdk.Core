using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBossFncPriceTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncPriceTaskCreateModel : AopObject
    {
        /// <summary>
        /// 系统名称/开放平台appId
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 价格任务请求详情参数，详见任务请求参数说明。
        /// </summary>
        [XmlElement("apply_detail")]
        public string ApplyDetail { get; set; }

        /// <summary>
        /// 扩展属性（Map<String, String>的JSON对象）  key和value中不能有英文逗号及等于符号。
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 任务创建人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 任务备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号，系统根据out_biz_no + source 来进行幂等控制，因此同一个任务来源的外部业务单号必须要保证不重复
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务来源类型
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 任务子类型，标识是一个新增的任务还是一个变更的任务，新增/变更。
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 任务类型（价格任务，政策任务，etc）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
