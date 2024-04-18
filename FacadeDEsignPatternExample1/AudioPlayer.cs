using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDEsignPatternExample1
{
    public class AudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing audio");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing audio");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping audio");
        }
    }
}
