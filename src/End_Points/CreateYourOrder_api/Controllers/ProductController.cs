using Application_Layer.Products;
using Application_Layer.Products.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace CreateYourOrder_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("/AdingP")]
        [HttpPost]
        public string AddNewProduct(AddProductDTO productDTO)
        {
           productService.CreateNewProduct(productDTO);
           return "OK, create Product is done";
        }

        [Route("/EditingP")]
        [HttpPut]
        public string EditeOldProduct(EditeProductDTO editeProduct)
        {
            productService.EditProduct(editeProduct);
            return "OK, Edite Product is done";
        }

        [Route("/DeletingP")]
        [HttpPut]
        public string DeleteExistProduct(DeleteProductDTO deleteDTO)
        {
            productService.DeleteProduct(deleteDTO);
            return "OK, Delete Product is done";
        }

        [Route("/GettingOneP")]
        [HttpGet]
        public ProductDTO GetOneProduct(long id)
        {
            return productService.GetProductById(id);
        }

        [Route("/AllP")]
        [HttpGet]
        public List<ProductDTO> GetAllProduct() {

            return productService.GetAllProduct();
        }
    }
}
