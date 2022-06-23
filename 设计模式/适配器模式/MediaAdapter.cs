using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 步骤 3 创建实现了 MediaPlayer 接口的适配器类
    /// 将已有的高级播放器与低级媒体播放器进行适配
    /// </summary>
    class MediaAdapter : MediaPlayer
    {
        //已有高级播放器，适配其MP4、VLC播放功能
        AdvancedMediaPlayer advancedMusicPlayer;

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
        //根据类型构造适配器
        public MediaAdapter(String audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

    }
}
