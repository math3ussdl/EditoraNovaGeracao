using EditoraNovaGeracao.Domain.Interfaces.Services;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.IO;
using System.Threading;

namespace EditoraNovaGeracao.Infra.CrossCutting.Services
{
    public class AudioService : IDisposable, IAudioService
    {
        private readonly WasapiCapture _capturer;

        public AudioService()
        {
            _capturer = new WasapiLoopbackCapture();
        }

        public void Record()
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
