﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using AudioBand.ViewModels;
using MahApps.Metro.Controls;
using NLog;

namespace AudioBand.Settings
{
    internal partial class SettingsWindow
    {
        private ILogger _logger = LogManager.GetCurrentClassLogger();
        internal AppearanceViewModel Appearance { get; set; }

        internal SettingsWindow(AppearanceViewModel appearance)
        {
            Appearance = appearance;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            InitializeComponent();
            DataContext = Appearance;
            _logger.Debug($"app {Appearance.AudioBandAppearance}");
        }

        // Problem loading xceed.wpf.toolkit assembly normally
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (!args.Name.StartsWith("Xceed.Wpf.Toolkit"))
            {
                return null;
            }

            var dir = DirectoryHelper.BaseDirectory;
            // name is in this format Xceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4
            var asmName = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
            var filename = Path.Combine(dir, asmName);

            return !File.Exists(filename) ? null : Assembly.LoadFrom(filename);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
