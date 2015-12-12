using WeiXin.Framework.Core;
using WeiXin.Framework.Core.Entities;
using System.Xml.Linq;

namespace WeiXin.Framework.Plugins
{
    /// <summary>
    /// 微信文本消息处理控制器
    /// </summary>
    public class WeiXinTextHandler : WeiXinHandlerType
    {
        #region 字段/属性

        /// <summary>
        /// 消息类型text
        /// </summary>
        public override WeiXinMsgType WeiXinMsgType
        {
            get { return WeiXinMsgType.Text; }
        }
        #endregion

        public override void ProcessWeiXin(WeiXinContext context)
        {
            WeiXinTextMessageEntity requestModel = context.Request.GetRequestModel<WeiXinTextMessageEntity>();
            WeiXinTextMessageEntity responseModel = new WeiXinTextMessageEntity
            {
                ToUserName = requestModel.FromUserName,
                FromUserName = requestModel.ToUserName,
                MsgType = WeiXinMsgType.Text.ToString(),
                Content = string.Format("第1题\r\n人民防空是（1）的重要组成部分，与要敌防空、野战防空共同构成三位一体的国土防空体系。\r\n1.国防\r\n2.武装力量\r\n3.军队")
            };
            context.Response.Write(responseModel);
        }
    }
}
