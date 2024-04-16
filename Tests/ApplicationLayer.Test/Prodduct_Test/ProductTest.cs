using Application_Layer.Products;
using Application_Layer.Products.DTOs;
using Domain_Layer.Products;
using Domain_Layer.Products.Repository;
using Domain_Layer.Shared.Value_Objects;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationLayer.Test.Prodduct_Test
{
    public class ProductTest
    {
        private readonly ProductService productService;
        private readonly IProductRepository repository;

        public ProductTest()
        {
            repository = Substitute.For<IProductRepository>();
            productService = new ProductService(repository);
        }

        [Fact]
        public void create_new_Product_service() {

            //arrange
            var ProductToCreate = new AddProductDTO("tittle", 10.5, 50);
            //act
            productService.CreateNewProduct(ProductToCreate);

            //assert
            repository.Received(1).SaveEveryThings();    
        }

        [Fact]
        public void Delete_Product_FormDataBase_service()
        {

            //arrange
            var product = repository.GetProductById(Arg.Any<long>()).Returns(new Product("tittle", Money.FromTooman(10), 22));
            var ProductToDelete = new DeleteProductDTO(1);

            //act
            productService.DeleteProduct(ProductToDelete);

            //assert
            repository.Received(1).SaveEveryThings();
        }

        [Fact]
        public void Edite_Product_Value_service()
        {

            //arrange
            var product = repository.GetProductById(1).Returns(new Product("tittle", Money.FromTooman(10), 22));
            var ProductToDelete = new EditeProductDTO(1, "tittle_Edited", 22.5, 2);

            //act
            productService.EditProduct(ProductToDelete);

            //assert
            repository.Received(1).SaveEveryThings();
        }

        [Fact]
        public void Get_By_Id_Product_service()
        {

            //arrange
            var product = repository.GetProductById(Arg.Any<long>()).Returns(new Product("tittle", Money.FromTooman(10), 22));
          

            //act
            var P = productService.GetProductById(1);

            //assert
            P.Tittle.Should().Be("tittle");
        }

        [Fact]
        public void Get_All_Product_Value_service()
        {

            //arrange
            var product = repository.GetProducts().Returns(

                    new List<Product>(){

                          new Product("tittle", Money.FromTooman(10), 22),
                        new Product("tittle2", Money.FromTooman(10), 12)
                   
                    });


            //act
            var P = productService.GetAllProduct();

            //assert
            P.Should().HaveCount(2);
        }
    }
}
