using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineCup.Quantum.Controller
{
    static public class MusicController
    {
        //effect.Play();
        public static float m_volume =  1.0f;
        public static void playBackSong(Song backSong)
        {
            MediaPlayer.Volume = m_volume;
            MediaPlayer.Play(backSong);
        }
    }
}
