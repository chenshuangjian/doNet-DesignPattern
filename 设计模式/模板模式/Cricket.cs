﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上述类的实体类。
    /// </summary>
    public class Cricket : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        public override void initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
    }
}
