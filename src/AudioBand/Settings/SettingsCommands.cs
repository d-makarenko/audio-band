﻿using System.Windows.Input;

namespace AudioBand.Settings
{
    public static class SettingsCommands
    {
        public static readonly RoutedCommand ResetImagePath = new RoutedCommand("Reset Path", typeof(SettingsCommands));
        public static readonly RoutedCommand ChooseImage = new RoutedCommand();
    }
}
