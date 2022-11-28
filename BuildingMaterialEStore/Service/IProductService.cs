﻿using BmesRestApi.Messages.Request.Product;
using BmesRestApi.Messages.Response.Product;

namespace BuildingMaterialEStore.Service
{
    public interface IProductService
    {
        CreateProductResponse SaveProduct(CreateProductRequest createProductRequest);
        UpdateProductResponse EditProduct(UpdateProductRequest updateProductRequest);
        GetProductResponse GetProduct(GetProductRequest getProductRequest);
        FetchProductsResponse GetProducts(FetchProductsRequest fetchProductsRequest);
        DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest);
    }
}
