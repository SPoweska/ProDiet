using AutoFixture;
using ProDiet.Data.Models;
using ProDietTests.Customizations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDietTests.Customizations.ProductsCustomization
{
    public class AlergeneCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new IgnoreMembers(new[]
            {
            nameof(Alergene.Product),
        }));
        }
    }
}
