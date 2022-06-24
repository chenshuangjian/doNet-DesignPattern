using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板模式
{
    /// <summary>
    /// 步骤 2 创建扩展了上述类的实体类。
    /// </summary>
    public class Football : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Football Game Finished!");
        }

        public override void initialize()
        {
            Console.WriteLine("Football Game Initialized! Start playing.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }
    }
}
