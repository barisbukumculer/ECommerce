﻿using ECommerce.DtoLayer.Dtos.AccountDto;
using ECommerce.DtoLayer.Dtos.Order;
using ECommerce.EntityLayer.Concrete;
using ECommerce.PresentationLayer.Models;
using ECommerce.PresentationLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.PresentationLayer.ViewComponents
{
    public class OrderDetailForUser : ViewComponent
    {
        private readonly ApiService _apiService;

        public OrderDetailForUser(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _apiService.GetTableData<OrderDetail>("https://localhost:7175/api/OrderDetail");
            var selectedValues = values.Where(x => x.OrderId == id).ToList();

            List<OrderDetailViewModel> result = new();

            foreach (var item in selectedValues)
            {
                OrderDetailViewModel viewModel = new()
                {
                    OrderId = item.OrderId,
                    Id = item.Id,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Product = await _apiService.GetData<Product>("https://localhost:7175/api/Product/GetProductById/" + item.ProductId)
                };
                result.Add(viewModel);
            }
            return View(result);
        }
    }
}
