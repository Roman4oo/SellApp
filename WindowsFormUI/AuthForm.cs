using BLL;
using BLL.Services;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class AuthForm : Form
    {
        private readonly IAuthService _authService;

        public AuthForm(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }


        

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            if (email_box.Text.Length == 0 || pas_box.Text.Length == 0)
            {
                MessageBox.Show("Login and password are required.");
            }
            else
            {
                LoginViewModel loginViewModel = new LoginViewModel();
                
                loginViewModel.Email = email_box.Text;
                loginViewModel.Password = pas_box.Text;
                try
                {
                    var user =_authService.SignIn(loginViewModel);
                    MainForm mainForm = DependencyInjectorUnity.Resolve<MainForm>();
                    mainForm.Show();
                    this.Hide();

                }
                catch(ValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = DependencyInjectorUnity.Resolve<RegistrationForm>();
            registrationForm.Show();
            this.Hide();
        }
    }
}
