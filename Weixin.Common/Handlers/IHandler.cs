﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiXin.Common.Handlers
{
    /// <summary>
    /// 处理接口
    /// </summary>
    public interface IHandler
    {
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        string HandleRequest();
    }
}
