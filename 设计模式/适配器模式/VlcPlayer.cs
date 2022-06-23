using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 步骤 2 创建实现了 AdvancedMediaPlayer 接口的实体类。
    /// VLC播放器实现
    /// </summary>
    class VlcPlayer : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            //什么也不作
        }

        public void playVlc(string fileName)
        {
            
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}
