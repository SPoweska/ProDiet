using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using ProDietTests.Customizations.InterviewCustomization;
using ProDietTests.Customizations.PateintsCustomization;
using ProDietTests.Infrastructure;
using Xunit;

namespace ProDietTests.Repository.Interview.InterviewStoresService
{
    [CollectionDefinition(nameof(InterviewTestsCollection))]
    public class InterviewTestsCollection:ICollectionFixture<InterviewTestsFixture>
    {
    }

    public class InterviewTestsFixture : BaseTestFixture
    {
        public const int Interview1Id = 1;

        public const int Interview2Id = 2;

        public const int Interview3Id = 3;

        public InterviewTestsFixture()
        {
            SeedInterviews();
        }
        private void SeedInterviews()
        {
            var interviews = new Fixture()
                .Customize(new InterviewCustomization())
                .CreateMany<ProDiet.Models.Interview>(3)
                .ToList();

            interviews[0].InterviewId = Interview1Id;
            interviews[0].PatientId=Interview1Id;

            interviews[1].InterviewId = Interview2Id;

            interviews[2].InterviewId = Interview3Id;
            

            Context.AddRange(interviews);
            Context.SaveChanges();
        }
    }
}
