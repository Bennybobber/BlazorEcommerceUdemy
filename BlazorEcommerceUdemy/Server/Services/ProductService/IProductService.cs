﻿namespace BlazorEcommerceUdemy.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductListAsync();
    }
}
