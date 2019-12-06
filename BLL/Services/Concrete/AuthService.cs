using AutoMapper;
using BLL.Services.Abstract;
using DAL.DTOs;
using DAL.Models.ViewModels;
using DAL.UnitOfWork;
using SellerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IHashingService _hashingService;
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthService(IHashingService hashingService, UnitOfWork unitOfWork, IMapper mapper)
        {
            _hashingService = hashingService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public UserDTO SignIn (LoginViewModel loginViewModel)
        {
            var existedUser = _unitOfWork.UserRepository.SingleOrDefault(u => u.Email == loginViewModel.Email);

            if (existedUser == null && !_hashingService.IsStringEqualHash(loginViewModel.Password, existedUser.Password))
            {
                throw new ValidationException("Invalid Credentials");
            }

            var userDTO = _mapper.Map<User, UserDTO>(existedUser);

            return userDTO;
        }
    }
}
