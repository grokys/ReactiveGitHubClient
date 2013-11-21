// -----------------------------------------------------------------------
// <copyright file="LoginView.xaml.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace ReactiveGitHubClient.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using ReactiveGitHubClient.ViewModels;
    using ReactiveUI;

    /// <summary>
    /// Interaction logic for the LoginView.
    /// </summary>
    public partial class LoginView : UserControl, IViewFor<LoginViewModel>
    {
        /// <summary>
        /// The dependency property declaration for the ViewModel.
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
                "ViewModel",
                typeof(LoginViewModel),
                typeof(LoginView));

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginView"/> class.
        /// </summary>
        public LoginView()
        {
            this.InitializeComponent();

            // We need to bind the ViewModel property to the DataContext in order to be able to
            // use WPF Bindings. Let's use WPF bindings for the UserName property.
            this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext);

            // And lets use ReactiveUI bindings for the Password property and the Login command. 
            // Note that we don't need to explicitly pass the control we're binding to here for 
            // Password, as the control is named the same as the property on the view model and
            // ReactiveUI is intelligent enough to realise we want to bind the Text property.
            this.Bind(this.ViewModel, x => x.Password);

            // For the LoginCommand on the other hand, we must use a one way binding and explicitly
            // specify the control and the property being bound to.
            this.OneWayBind(this.ViewModel, x => x.LoginCommand, x => x.okButton.Command);
        }

        /// <summary>
        /// Gets or sets the view's ViewModel.
        /// </summary>
        public LoginViewModel ViewModel
        {
            get { return (LoginViewModel)this.GetValue(ViewModelProperty); }
            set { this.SetValue(ViewModelProperty, value); }
        }

        /// <summary>
        /// Gets or sets the view's ViewModel.
        /// </summary>
        object IViewFor.ViewModel
        {
            get { return this.ViewModel; }
            set { this.ViewModel = (LoginViewModel)value; }
        }
    }
}
