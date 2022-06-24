using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板模式
{
    /// <summary>
    /// 步骤 3 使用 Game 的模板方法 play() 来演示游戏的定义方式。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();
            Console.WriteLine();
            game = new Football();
            game.play();
        }
    }
}
