using DAL.DTOs;
using DAL.Models.ViewModels;
using SellerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IProductService
    {

        void Add(ProductViewModel productViewModel);
        void UpdateIsSoldPropertyIfNoTransaction();

        List<Product> GetAll();
    }
}
