﻿using AutoMapper;
using BLL.Services;
using BLL.Services.Abstract;
using BLL.Services.Concrete;
using DAL.UnitOfWork;
using SellerApp;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace BLL
{
    public class DependencyInjectorUnity
    {
        private readonly static IUnityContainer _container = Register();
        private static IUnityContainer Register()
        {
            var container = new UnityContainer();

            container.RegisterType<IAuthService, AuthService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ITransactionService, TransactionService>();
            container.RegisterType<SellAppContext>(new PerThreadLifetimeManager());
            container.RegisterType< IHashingService, HashingService>();
            container.RegisterInstance<IMapper>(MapperConfig.CreateMapper(), InstanceLifetime.Singleton);

            return container;
        }
        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _container.Resolve<T>(overrides);
        }
    }
}
