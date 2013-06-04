﻿// ---------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Walletex Microelectronics LTD">
//     Copyright (c) Walletex Microelectronics LTD, Israel 2011. All rights reserved.
//     Author: alex
//     Date: 26-5-2013
// </copyright>
// -----------------------------------------------------------------------------
namespace SwiftSharp
{
    using System.Windows;
    using SwiftSharp.Gui.Model;
    using SwiftSharp.Gui.View;
    using SwiftSharp.Gui.ViewModel;

    /// <summary>
    /// Interaction logic for App
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainModel model = new MainModel();
            MainViewModel viewModel = new MainViewModel(model);

            this.MainWindow = new MainWindow(viewModel);
            this.MainWindow.Show();
        }
    }
}
