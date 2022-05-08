using AutoFixture;
using FluentAssertions;
using ProDiet.Models;
using ProDiet.Services;
using ProDietTests.Customizations.ProductsCustomization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProDietTests.Repository.Products.ProductsStoreService
{
    [Collection(nameof(ProductsTestsCollection))]
    public class ProductsTests
    {
        public readonly ProductsTestsFixture _fixture;
        public readonly ProductStoresService _productStoresService;

        public ProductsTests(ProductsTestsFixture fixture)
        {
            _fixture = fixture;
            _productStoresService = new ProductStoresService(fixture.Context);
        }

        [Fact]
        public async Task CreateProduct_WhenAllDataIsCorrect_CreatesProduct()
        {
            var product = new Fixture()
                .Customize(new ProductsCustomization())
                .Create<Product>();

            await _productStoresService.AddProduct(product);

            var products = _fixture.Context.Products.ToList();
            products.Should().HaveCount(ProductsTestsFixture.ProductsCount + 1);
        }

        [Fact]
        public async Task CheckProductOwner_WhenOwnerExists_ReturnsTrue()
        {
            var response = await _productStoresService.CheckOwner(ProductsTestsFixture.ExistingOwnerId, ProductsTestsFixture.Product1Id); ;

            response.Should().BeTrue();
        }

        [Fact]
        public async Task CheckProductOwner_WhenOwnerNotExists_ReturnsFalse()
        {
            var response = await _productStoresService.CheckOwner(ProductsTestsFixture.NotExistingOwnerId, ProductsTestsFixture.Product1Id); ;

            response.Should().BeFalse();
        }

        [Fact]
        public async Task CountsProductsForUser_WhenOwnerExists_ReturnsProductsCount()
        {
            var response = await _productStoresService.CountAllUsersProducts(ProductsTestsFixture.ExistingOwnerId); ;

            response.Should().Be(ProductsTestsFixture.ProductsCountForUser);
        }


        [Fact]
        public void DeleteProduct_WhenAllDataIsCorrect_DeletesProduct()
        {
            _productStoresService.DeleteProduct(ProductsTestsFixture.Product3Id); // metoda jest voidem

            var products = _fixture.Context.Products.ToList();
            products.Should().HaveCount(ProductsTestsFixture.ProductsCount);
        }

        [Fact]
        public async Task GetProductData_WhenProductNotExists_ThrowsArgumentNullException()
        {
            Func<Task> action = async () => await _productStoresService.GetProductData(ProductsTestsFixture.NotExistingProductId);
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task GetProductData_WhenProductExists_ReturnsProduct()
        {
            var product = await _productStoresService.GetProductData(ProductsTestsFixture.Product1Id);

            product.Should().NotBeNull();
            product.Alergenes.Should().HaveCount(ProductsTestsFixture.AllergeneCount);
        }

    }
}
