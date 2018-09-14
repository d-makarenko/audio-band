using System;
using System.ServiceModel;
using AudioBand.AudioSource;

namespace AudioBand.AudioSourceService
{
    // Server side
    [ServiceContract(CallbackContract = typeof(IAudioSourceServiceCallback))]
    public interface IAudioSourceService
    {
        [OperationContract(IsOneWay = true)]
        void Connect();

        [OperationContract(IsOneWay = true)]
        void TrackInfoChanged(TrackInfoChangedEventArgs e);

        [OperationContract(IsOneWay = true)]
        void TrackPlaying();

        [OperationContract(IsOneWay = true)]
        void TrackPaused();

        [OperationContract(IsOneWay = true)]
        void TrackProgressChanged(TimeSpan progress);
    }
}
