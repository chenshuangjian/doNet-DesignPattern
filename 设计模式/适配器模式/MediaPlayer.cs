using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 步骤 1 为媒体播放器和更高级的媒体播放器创建接口
    /// </summary>
    public interface MediaPlayer
    {
        void play(String audioType, String fileName);
    }
}
