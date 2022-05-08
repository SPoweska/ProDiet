using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using ProDiet.Data.Models;
using ProDiet.Migrations;
using ProDiet.Models;
using ProDietTests.Customizations.PateintsCustomization;
using ProDietTests.Customizations.ProductsCustomization;
using ProDietTests.Infrastructure;
using ProDietTests.Repository.Products.ProductsStoreService;
using Xunit;

namespace ProDietTests.Repository.Patients.PatientsStoreService
{
    [CollectionDefinition(nameof(PatientTestsCollection))]
    public class PatientTestsCollection : ICollectionFixture<PatientsTestsFixture>
    {
    }

    public class PatientsTestsFixture:BaseTestFixture
    {
        public const int Patient1Id = 1;

        public const int Patient2Id = 2;

        public const int Patient3Id = 3;

        public static string ExistingOwnerId = "1";
        public static string NotExistingOwnerId = "2";
        public static string PatientCreator = "1";


        public PatientsTestsFixture()
        {
            SeedPatients();
        }


        private void SeedPatients()
        {
            var patients = new Fixture()
                .Customize(new PatientCustomization())
                .CreateMany<Patient>(3)
                .ToList();

            patients[0].Id = Patient1Id;
            patients[0].CreatedBy = ExistingOwnerId;
            patients[0].CreatedBy = PatientCreator;
            //patients[0].CreatedBy = ExistingOwnerId;
            //patients[0].Alergenes = new Fixture()
            //    .Customize(new AlergeneCustomization())
            //    .Build<Alergene>()
            //    .With(x => x.ProductId, Product1Id)
            //    .CreateMany<Alergene>(AllergeneCount)
            //    .ToList();

            patients[1].Id = Patient2Id;
            patients[1].CreatedBy = PatientCreator;
            //patients[1].CreatedBy = ExistingOwnerId;

            patients[2].Id = Patient3Id;

            Context.AddRange(patients);
            Context.SaveChanges();
        }
    }

}
