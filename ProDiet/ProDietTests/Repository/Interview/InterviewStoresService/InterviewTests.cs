using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using ProDietTests.Customizations.InterviewCustomization;
using ProDietTests.Customizations.PateintsCustomization;
using Xunit;

namespace ProDietTests.Repository.Interview.InterviewStoresService
{
    [Collection(nameof(InterviewTestsCollection))]

    public class InterviewTests
    {
        public readonly InterviewTestsFixture _fixture;
        public readonly ProDiet.Services.InterviewStoresService _interviewStoresService;

        public InterviewTests(InterviewTestsFixture fixture)
        {
            _fixture=fixture;
            _interviewStoresService = new ProDiet.Services.InterviewStoresService(fixture.Context);
        }

        [Fact]
        public async Task UpdateInterview_WhenAllDataIsCorrect_InterviewUpdated()
        {
            var interview = _fixture.Context.Interviews.FirstOrDefault(x => x.InterviewId == 1);
            interview.DailySnacksAmount = "1";
            await _interviewStoresService.UpdateInterview(interview);
            var interviews = _fixture.Context.Interviews.FirstOrDefault(x => x.InterviewId == interview.InterviewId);
            interviews.DailySnacksAmount.Should().BeEquivalentTo(interview.DailySnacksAmount);

        }

        [Fact]
        public async Task GetInterviewData_WhenAllDataIsCorrect_ReturnsInterview()
        {
            var interview = await _interviewStoresService.GetInterviewData(InterviewTestsFixture.Interview1Id);
            interview.Should().BeSameAs(interview);
        }




    }
}
