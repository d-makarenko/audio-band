﻿using System.Collections.Generic;
using AudioBand.ViewModels;

namespace AudioBand.Settings
{
    internal class AudioBandSettings
    {
        public string Version { get; set; } = "0.1";
        public string AudioSource { get; set; }
        public AudioBandAppearance AudioBandAppearance { get; set; } = new AudioBandAppearance();
        public PlayPauseButtonAppearance PlayPauseButtonAppearance { get; set; } = new PlayPauseButtonAppearance();
        public NextSongButtonAppearance NextSongButtonAppearance { get; set; } = new NextSongButtonAppearance();
        public PreviousSongButtonAppearance PreviousSongButtonAppearance { get; set; } = new PreviousSongButtonAppearance();
        public List<TextAppearance> TextAppearances { get; set; } = new List<TextAppearance>(){new TextAppearance{Name = "1"}, new TextAppearance { Name = "2" } };
        public ProgressBarAppearance ProgressBarAppearance { get; set; } = new ProgressBarAppearance();
        public AlbumArtDisplay AlbumArtAppearance { get; set; } = new AlbumArtDisplay();
        public AlbumArtPopup AlbumArtPopupAppearance { get; set; } = new AlbumArtPopup();
    }
}
