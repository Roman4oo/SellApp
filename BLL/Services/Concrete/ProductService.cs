using AutoMapper;
using BLL.Services.Abstract;
using DAL.DTOs;
using DAL.Models.ViewModels;
using DAL.UnitOfWork;
using SellerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concrete
{
    class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ProductViewModel productViewModel)
        {

            ProductDTO productDTO = new ProductDTO
            {
                Name = productViewModel.Name,
                Price = productViewModel.Price,
                IsSold = false
            };

            _unitOfWork.ProductRepository.Add(_mapper.Map<ProductDTO, Product>(productDTO));
            _unitOfWork.Complete();
        }

        public List<Product> GetAll()
        {
            var products = _unitOfWork.ProductRepository.GetAll().ToList();

            foreach(var product in products)
            {
                _mapper.Map<Product, ProductDTO>(product);
            }
            return products;
        }

        public void UpdateIsSoldPropertyIfNoTransaction()
        {
            var products = _unitOfWork.ProductRepository.GetAll();

            foreach(Product product in products)
            {

                if(product.ProductsTransactions.Count == 0)
                {
                    product.IsSold = false;
                }

                _unitOfWork.ProductRepository.Update(product);
                _unitOfWork.Complete();
            }
        }



    }
}
