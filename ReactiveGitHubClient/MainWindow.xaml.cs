// -----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace ReactiveGitHubClient
{
    using System.Windows;
    using ReactiveGitHubClient.ViewModels;

    /// <summary>
    /// Interaction logic for the MainWindow view.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
