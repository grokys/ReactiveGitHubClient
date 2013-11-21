// -----------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace ReactiveGitHubClient.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// The view model for the login page.
    /// </summary>
    public class LoginViewModel : ReactiveObject
    {
        /// <summary>
        /// The username.
        /// </summary>
        private string userName;

        /// <summary>
        /// The password.
        /// </summary>
        private string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginViewModel"/> class.
        /// </summary>
        public LoginViewModel()
        {
            // The login command is only enabled when both a user name and password have been 
            // entered.
            this.LoginCommand = new ReactiveCommand(
                this.WhenAny(
                    x => x.UserName,
                    x => x.Password,
                    (userName, password) => 
                        !string.IsNullOrWhiteSpace(userName.Value) && 
                        !string.IsNullOrWhiteSpace(password.Value)));
        }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.RaiseAndSetIfChanged(ref this.userName, value); }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.RaiseAndSetIfChanged(ref this.password, value); }
        }

        /// <summary>
        /// Gets the command executed when the user clicks the "OK" button.
        /// </summary>
        public ReactiveCommand LoginCommand
        {
            get;
            private set;
        }
    }
}
