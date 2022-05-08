using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using ProDiet.Models;
using ProDietTests.Customizations.Builders;

namespace ProDietTests.Customizations.PateintsCustomization
{
    public class PatientCustomization:ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new IgnoreMembers(new[]
            {
                nameof(Patient.Interview),
                nameof(Patient.BodyMeasurements),
                nameof(Patient.PatientAlergenes),
                nameof(Patient.PatientIntolerances),
                nameof(Patient.DietPlans)
                
            }));

        }
    }
}
