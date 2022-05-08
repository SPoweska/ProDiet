using AutoFixture;
using ProDiet.Data.Models;
using ProDiet.Migrations;
using ProDiet.Models;
using ProDietTests.Customizations.ProductsCustomization;
using ProDietTests.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProDietTests.Repository.Products.ProductsStoreService
{
    [CollectionDefinition(nameof(ProductsTestsCollection))]
    public class ProductsTestsCollection : ICollectionFixture<ProductsTestsFixture>
    {
    }

    public class ProductsTestsFixture : BaseTestFixture
    {
        public const int Product1Id = 1;

        public const int Product2Id = 2;

        public const int Product3Id = 3;

        public const int NotExistingProductId = 124214;

        public const int ProductsCount = 3;

        public const int AllergeneCount = 3;

        public const int ProductsCountForUser = 2;

        public static string ExistingOwnerId = "1";

        public static string NotExistingOwnerId = "124421";

        public ProductsTestsFixture()
        {
            SeedProducts();
        }

        private void SeedProducts()
        {
            var products = new Fixture()
            .Customize(new ProductsCustomization())
            .CreateMany<Product>(3)
            .ToList();

            products[0].ProductId = Product1Id;
            products[0].CreatedBy = ExistingOwnerId;
            products[0].Alergenes = new Fixture()
                .Customize(new AlergeneCustomization())
                .Build<Alergene>()
                .With(x => x.ProductId, Product1Id)
                .CreateMany<Alergene>(AllergeneCount)
                .ToList();

            products[1].ProductId = Product2Id;
            products[1].CreatedBy = ExistingOwnerId;

            products[2].ProductId = Product3Id;

            Context.AddRange(products);
            Context.SaveChanges();
        }
    }
}
