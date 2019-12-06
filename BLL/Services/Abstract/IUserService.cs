using DAL.DTOs;
using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Abstract
{
    public interface IUserService
    {
        UserDTO CreateUser(RegistrationViewModel registrationViewModel);
    }
}
