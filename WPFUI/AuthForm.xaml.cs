using BLL;
using BLL.Services;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for AuthForm.xaml
    /// </summary>
    public partial class AuthForm : Window
    {
        private readonly IAuthService _authService;
        public AuthForm(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void log_in_btn_Click(object sender, RoutedEventArgs e)
        {
            if (login_box.Text.Length == 0 || pas_box.Text.Length == 0)
            {
                MessageBox.Show("Login and password are required.");
            }
            else
            {
                LoginViewModel loginViewModel = new LoginViewModel();

                loginViewModel.Email = login_box.Text;
                loginViewModel.Password = pas_box.Text;
                try
                {
                    var user = _authService.SignIn(loginViewModel);
                    ControlWindow controlWindow = DependencyInjectorUnity.Resolve<ControlWindow>();
                    controlWindow.Show();
                    this.Hide();

                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sign_up_btn_Click(object sender, RoutedEventArgs e)
        {
            CreateUserWindow createUserWindow = DependencyInjectorUnity.Resolve<CreateUserWindow>();
            createUserWindow.Show();
            this.Hide();
        }
    }
}
