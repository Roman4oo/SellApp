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
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IHashingService _hashingService;
        private readonly IMapper _mapper;

        public UserService(IHashingService hashingService, UnitOfWork unitOfWork, IMapper mapper)
        {
            _hashingService = hashingService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public UserDTO CreateUser (RegistrationViewModel registrationViewModel)
        {
            var existedUser = _unitOfWork.UserRepository.SingleOrDefault(u => u.Email == registrationViewModel.Email);

            var userDTO = new UserDTO()
            {
                Email = registrationViewModel.Email,

                Password = _hashingService.CreateHash(registrationViewModel.Password),
                FirstName = registrationViewModel.FirstName,
                LastName = registrationViewModel.LastName,
                RoleId = 1
            };
            
            var user = _mapper.Map<UserDTO, User>(userDTO);


            if (existedUser == null)
            {
                _unitOfWork.UserRepository.Add(user);
                _unitOfWork.Complete();
            }

            else
            {
                throw new ValidationException("User already exist");
            }

            return userDTO;
        }
    }
}
