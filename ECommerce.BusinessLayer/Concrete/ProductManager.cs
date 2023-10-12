﻿using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.EntityFramework;
using ECommerce.DtoLayer.Dtos.Product;
using ECommerce.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace ECommerce.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public async Task TDeleteAsync(Product t)
		{
			await _productDal.DeleteAsync(t);
		}

		public async Task<Product> TGetByIdAsync(int id)
		{
			return await _productDal.GetByIdAsync(id);
		}

		public async Task<List<Product>> TGetListAsync()
		{
			return await _productDal.GetListAsync();
		}

        public async Task<List<Product>> TGetListByFilter(Expression<Func<Product, bool>> filter)
        {
            return await _productDal.GetListByFilter(filter);
        }

        public async Task<List<ResultProductDto>> TGetProductList()
        {
            return await _productDal.GetProductList();
        }

		public async Task<List<ResultProductDto>> TGetSearchedProductList(string searchTerm)
		{
			return await _productDal.GetSearchedProductList(searchTerm);
		}

		public async Task TInsertAsync(Product t)
		{
			await _productDal.InsertAsync(t);
		}

		public async Task TUpdateAsync(Product t)
		{
			await _productDal.UpdateAsync(t);
		}
	}
}
