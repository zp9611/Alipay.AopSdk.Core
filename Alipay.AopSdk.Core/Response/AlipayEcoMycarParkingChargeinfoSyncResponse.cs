using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingChargeinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingChargeinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
