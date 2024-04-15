using Application_Layer.Products.DTOs;
using Domain_Layer.Products;
using Domain_Layer.Products.Repository;
using Domain_Layer.Shared.Value_Objects;
using System.Data;
using System.Net.Http.Headers;

namespace Application_Layer.Products
{
    public class ProductService : IProductService
    {
        IProductRepository repository;
        public ProductService(IProductRepository _repository)
        {
            repository = _repository;
        }

        public void CreateNewProduct(AddProductDTO Command)
        {
            //process of creating a new product
            var product = new Product(Command.Tittle, Money.FromTooman(Command.Price), Command.Count);
            repository.Add(product);    
            repository.SaveEveryThings();

          
        }

        public void DeleteProduct(DeleteProductDTO delete)
        {
            var oldP = repository.GetProductById(delete.id);
            if (oldP != null)
            {
                repository.Delete(oldP);
                repository.SaveEveryThings();
            }

        }

        public void EditProduct(EditeProductDTO editeDTO)
        {
            var product = repository.GetProductById(editeDTO.id);
            if (product != null)
            {
                //first change values by the entity  itself
               product.Edite(editeDTO.Tittle,Money.FromTooman(editeDTO.Price),editeDTO.Count);
                
                //then update information aboute that object in database and save
                repository.Update(product);
                repository.SaveEveryThings();

               
            }
        }

        public List<ProductDTO> GetAllProduct()
        {
            //map from domain model type to DTOs

            return repository.GetProducts().Select(p => new ProductDTO()
            {
                productId = p.Id,
                Tittle = p.Tittle,
                Price = p.Price.RialValue,
                Count = p.Count

            }).ToList();
        }

        public ProductDTO GetProductById(long id)
        {

            //map from domain model type to DTOs

            var p = repository.GetProductById(id);
            return new ProductDTO()
            {
                productId = p.Id,
                Tittle = p.Tittle,
                Price = p.Price.RialValue,
                Count = p.Count
            };
        }
    }

    
}
