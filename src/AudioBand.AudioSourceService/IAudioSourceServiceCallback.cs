using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using AudioBand.AudioSource;

namespace AudioBand.AudioSourceService
{
    // Client side
    [ServiceContract]
    public interface IAudioSourceServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnConnectionEstablished();

        [OperationContract]
        string GetName();

        [OperationContract(IsOneWay = true)]
        Task ChangeAudioSourceAsync(string audioSourceFolder);

        [OperationContract(IsOneWay = true)]
        Task ActivateAsync(IAudioSourceContext context, CancellationToken cancellationToken = default(CancellationToken));

        [OperationContract(IsOneWay = true)]
        Task DeactivateAsync(CancellationToken cancellationToken = default(CancellationToken));

        [OperationContract(IsOneWay = true)]
        Task PlayTrackAsync(CancellationToken cancellationToken = default(CancellationToken));

        [OperationContract(IsOneWay = true)]
        Task PauseTrackAsync(CancellationToken cancellationToken = default(CancellationToken));

        [OperationContract(IsOneWay = true)]
        Task PreviousTrackAsync(CancellationToken cancellationToken = default(CancellationToken));

        [OperationContract(IsOneWay = true)]
        Task NextTrackAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
