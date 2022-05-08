using AutoFixture;
using ProDiet.Models;
using ProDietTests.Customizations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDietTests.Customizations.ProductsCustomization
{
    public class ProductsCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new IgnoreMembers(new[]
            {
            nameof(Product.Alergenes),
            nameof(Product.Intolerances),
            nameof(Product.Nutrients),
            nameof(Product.HomeMeasurement)
        }));

        }
    }
}
