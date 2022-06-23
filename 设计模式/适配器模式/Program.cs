using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 步骤 5 使用 AudioPlayer 来播放不同类型的音频格式。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.play("mp3", "beyond the horizon.mp3");
            audioPlayer.play("mp4", "alone.mp4");
            audioPlayer.play("vlc", "far far away.vlc");
            audioPlayer.play("avi", "mind me.avi");
        }
    }
}
