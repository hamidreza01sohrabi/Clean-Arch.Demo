using Application_Layer.Products.DTOs;
using Domain_Layer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Products
{
    public interface IProductService
    {
        // useCase For Product Entity
        void CreateNewProduct(AddProductDTO Command);
        void EditProduct(EditeProductDTO editeDTO);
        void DeleteProduct(DeleteProductDTO deleteDTO);
        ProductDTO GetProductById(Guid id);
        List<ProductDTO> GetAllProduct();
    }
}
