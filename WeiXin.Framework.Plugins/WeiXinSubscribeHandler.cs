using System;
using System.Xml.Linq;
using WeiXin.Framework.Core;

namespace WeiXin.Framework.Plugins
{
    /// <summary>
    /// 微信用户关注事件控制器
    /// </summary>
    public class WeiXinSubscribeHandler : WeiXinHandlerType
    {
        #region 字段/属性

        /// <summary>
        /// 消息类型Event
        /// </summary>
        public override WeiXinMsgType WeiXinMsgType
        {
            get { return WeiXinMsgType.Event; }
        }

        /// <summary>
        /// 用户关注事件
        /// </summary>
        public override WeiXinEventType WeiXinEventType
        {
            get { return WeiXinEventType.SubScribe; }
        }

        #endregion

        public override void ProcessWeiXin(WeiXinContext context)
        {
            XElement result = new XElement("xml", new XElement("ToUserName", context.Request.FromUserName),
                new XElement("FromUserName", context.Request.ToUserName),
                new XElement("CreateTime", DateTime.Now.GetInt()),
                new XElement("MsgType", WeiXinMsgType.News.ToString().ToLower()),
                new XElement ("ArticleCount",3),
                new XElement("Articles",new XElement ("item",new XElement("Title","欢迎关注民防问答！"),
                new XElement("Description", ""),
                new XElement("PicUrl", "http://discuz.comli.com/weixin/weather/icon/cartoon.jpg"),
                new XElement("Url", "")), new XElement("item", new XElement("Title", "※  玩法介绍  → "), new XElement("Url", "http://geodigital.cn/MFZB/menu/wanfajieshao.html")),
                                          new XElement("item", new XElement("Title", "回复任意字符开始游戏吧！"))
                    ));
            context.Response.Write(result);
        }
    }
}
