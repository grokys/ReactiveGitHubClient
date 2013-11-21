// -----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace ReactiveGitHubClient
{
    using System.Windows;
    using ReactiveGitHubClient.ViewModels;
    using ReactiveGitHubClient.Views;
    using ReactiveUI;

    /// <summary>
    /// The WPF application.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            RxApp.MutableResolver.Register(() => new LoginView(), typeof(IViewFor<LoginViewModel>));
        }
    }
}
