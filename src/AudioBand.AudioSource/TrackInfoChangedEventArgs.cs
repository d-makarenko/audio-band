using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace AudioBand.AudioSource
{
    [DataContract]
    public class TrackInfoChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Track Name
        /// </summary>
        [DataMember]
        public string TrackName { get; set; }

        /// <summary>
        /// Artist
        /// </summary>
        [DataMember]
        public string Artist { get; set; }

        /// <summary>
        /// Album art image. If null, a placeholder will be used
        /// </summary>
        [DataMember]
        public Image AlbumArt { get; set; }
    }
}
