﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeSocket.Core.Interface
{
    public interface IDynamicBuffer:IFixedBuffer
    {
        /// <summary>
        /// 设置缓冲器大小
        /// </summary>
        /// <param name="size"></param>
        void SetBufferSize(int size);
    }
}
