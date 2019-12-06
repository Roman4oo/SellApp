using AutoMapper;
using DAL.DTOs;
using SellerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class MapperConfig
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<Role, RoleDTO>();
                cfg.CreateMap<RoleDTO, Role>();
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<Transaction, TransactionDTO>();
                cfg.CreateMap<TransactionDTO, Transaction>();
                cfg.CreateMap<ProductTransaction, ProductTransactionDTO>();
                cfg.CreateMap<ProductTransactionDTO, ProductTransaction>();
            }).CreateMapper();
        }
    }
}
