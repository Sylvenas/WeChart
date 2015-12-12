using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using WeiXin.Framework.Core;
using WeiXin.Framework.Core.Entities;

namespace WeiXin.Framework.Plugins
{
    /// <summary>
    /// 点击菜单拉取消息时的事件推送
    /// </summary>
    class WeiXinClickHandler:WeiXinHandlerType
    {
        #region 字段/属性
        public override WeiXinMsgType WeiXinMsgType
        {
            get { return WeiXinMsgType.Event; }
        }
        public override WeiXinEventType WeiXinEventType
        {
            get
            {
                return WeiXinEventType.Click;
            }
        }
        #endregion

        public override void ProcessWeiXin(WeiXinContext context)
        {
            string result = string.Empty;
            XElement ClickEventXML = context.Request.RequestXmlElement;
            string btnKey = ClickEventXML.Element("EventKey").Value;
            switch (btnKey)
            {
                case "btn1":
                    btn1(context);
                    break;
                case "btn2":
                    result = btn2(context);
                    break;
                case "btn3":
                    result = btn3(context);
                    break;
                case "btn4":
                    result = btn4(context);
                    break;
                case "btn5":
                    result = btn5(context);
                    break;
                case "btnTuiChu":
                    result = btnTuiChu(context);
                    break;
            }
        }

        private string btnTuiChu(WeiXinContext context)
        {
            throw new NotImplementedException();
        }

        private string btn5(WeiXinContext context)
        {
            throw new NotImplementedException();
        }

        private string btn4(WeiXinContext context)
        {
            throw new NotImplementedException();
        }

        private string btn3(WeiXinContext context)
        {
            throw new NotImplementedException();
        }

        private string btn2(WeiXinContext context)
        {
            throw new NotImplementedException();
        }

        private void btn1(WeiXinContext context)
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
