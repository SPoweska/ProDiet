using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using ProDiet.Models;
using ProDietTests.Customizations.Builders;

namespace ProDietTests.Customizations.InterviewCustomization
{
    internal class InterviewCustomization: ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new IgnoreMembers(new[]
            {
                nameof(Interview.Patient)
                

            }));

        }
    }
}
