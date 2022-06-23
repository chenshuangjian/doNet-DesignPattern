using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 步骤 2 创建实现了 AdvancedMediaPlayer 接口的实体类。
    /// Mp4播放器实现
    /// </summary>
    class Mp4Player : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }

        public void playVlc(string fileName)
        {
            //什么也不做
        }
    }
}
