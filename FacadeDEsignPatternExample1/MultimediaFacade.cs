using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDEsignPatternExample1
{
    public class MultimediaFacade
    {
        private VideoPlayer _videoPlayer;
        private AudioPlayer _audioPlayer;
        private Projector _projector;

        public MultimediaFacade(VideoPlayer videoPlayer, AudioPlayer audioPlayer, Projector projector)
        {
            _videoPlayer = videoPlayer;
            _audioPlayer = audioPlayer;
            _projector = projector;
        }

        public void Play()
        {
            _videoPlayer.Play();
            _audioPlayer.Play();
            _projector.TurnOn();
        }
        public void Pause()
        {
            _videoPlayer.Pause();
            _audioPlayer.Pause();
        }
        public void Stop()
        {
            _videoPlayer.Stop();
            _audioPlayer.Stop();
            _projector.TurnOff();

        }
    }
}
