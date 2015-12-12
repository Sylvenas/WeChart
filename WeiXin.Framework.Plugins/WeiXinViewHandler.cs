using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiXin.Framework.Core;

namespace WeiXin.Framework.Plugins
{
    /// <summary>
    /// 点击菜单拉取消息时的事件推送
    /// </summary>
    class WeiXinViewHandler:WeiXinHandlerType
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
                return WeiXinEventType.View;
            }
        }
        #endregion
        public override void ProcessWeiXin(WeiXinContext context)
        {
            
        }
    }
}
