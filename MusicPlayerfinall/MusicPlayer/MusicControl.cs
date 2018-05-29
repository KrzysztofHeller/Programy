using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Drawing;

namespace MusicPlayer
{
    static public class MusicControl
    {
        
        public static void DisposeWave(WaveOutEvent output)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (output != null)
            {
                output.Dispose();
                output = null;
            }
        }

        public static void Tracbarinit(TrackBar trackBar1)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = 100;
            trackBar1.TickFrequency = 10;
        }

        public static void Pasekpozycjiinit(AudioFileReader stream, TrackBar Pasekpozycji)
        {
            string duration = stream.TotalTime.ToString("mm\\:ss");


            Pasekpozycji.Minimum = 0;
            Pasekpozycji.Maximum = (int)stream.TotalTime.TotalSeconds;
            Pasekpozycji.Value = 0;
            Pasekpozycji.TickFrequency = (int)stream.TotalTime.TotalSeconds / 100;
        }

        public static void PlayMusic(WaveOutEvent output,Button Playbutton)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                    Playbutton.Image = Image.FromFile(@"1.png");
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                    Playbutton.Image = Image.FromFile(@"2.png");
                }
            }
        }

        public static void ResetMusic(AudioFileReader stream, WaveOutEvent output)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                    stream.Position = 0;
                    output.Play();
                }
            }
        }


    }
}
