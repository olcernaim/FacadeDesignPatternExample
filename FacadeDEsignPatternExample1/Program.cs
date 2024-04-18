using System;

namespace FacadeDEsignPatternExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultimediaFacade facade = new MultimediaFacade(new VideoPlayer(), new AudioPlayer(), new Projector());
            facade.Play();
        }
    }
}
