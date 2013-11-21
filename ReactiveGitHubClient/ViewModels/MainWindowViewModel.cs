// -----------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace ReactiveGitHubClient.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// View model for the application main window.
    /// </summary>
    public class MainWindowViewModel : ReactiveObject
    {
        /// <summary>
        /// The content of the main window.
        /// </summary>
        private ReactiveObject content;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            // Initally show the login view.
            this.content = new LoginViewModel();
        }

        /// <summary>
        /// Gets the content of the main window.
        /// </summary>
        public ReactiveObject Content
        {
            get { return this.content; }
            private set { this.RaiseAndSetIfChanged(ref this.content, value); }
        }
    }
}
