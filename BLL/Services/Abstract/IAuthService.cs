using DAL.DTOs;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using BLL.Services.Abstract;

namespace BLL.Services
{
    public interface IAuthService
    {
        UserDTO SignIn(LoginViewModel loginViewModel);

    }
}
