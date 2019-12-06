using BLL.Services.Abstract;
using DAL.Models.ViewModels;
using System;
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

                _userService.CreateUser(registrationViewModel);

                MessageBox.Show("User have been created successfully");
            }



        }
    }
}
