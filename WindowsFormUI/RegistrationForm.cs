using BLL;
using BLL.Services.Abstract;
using DAL.Models.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;


        public RegistrationForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {

            if (email_box.TextLength == 0 && pas_box.TextLength == 0 && fname_box.TextLength == 0 && lname_box.TextLength == 0)
            {
                MessageBox.Show("Fields can't be empty");
            }
            else
            {
                RegistrationViewModel registrationViewModel = new RegistrationViewModel()
                {
                    Email = email_box.Text,
                    Password = pas_box.Text,
                    FirstName = fname_box.Text,
                    LastName = lname_box.Text
                };
                try
                { 
                    _userService.CreateUser(registrationViewModel);

                    MessageBox.Show("User has benn created successfully");

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

        private void backToLogin_btn_Click(object sender, EventArgs e)
        {
            AuthForm AuthForm = DependencyInjectorUnity.Resolve<AuthForm>();
            AuthForm.Show();
            this.Hide();
        }
    }
}
