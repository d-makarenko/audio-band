using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AudioBand.AudioSource
{
    // Server side
    [ServiceContract(CallbackContract = typeof(IAudioSourceCallback))]
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
