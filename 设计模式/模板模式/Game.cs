using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板模式
{
    /// <summary>
    /// 步骤 1 创建一个抽象类，它的模板方法被设置为 final。
    /// </summary>
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        //模板
        public  void play()
        {

            //初始化游戏
            initialize();

            //开始游戏
            startPlay();

            //结束游戏
            endPlay();
        }
    }
}
