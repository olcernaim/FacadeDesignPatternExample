using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDEsignPatternExample1
{
    public class VideoPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing Video");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing Video");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping Video");
        }
    }
}
