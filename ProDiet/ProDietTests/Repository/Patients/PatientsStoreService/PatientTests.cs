using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using ProDiet.Models;
using ProDiet.Services;
using ProDietTests.Customizations.PateintsCustomization;
using ProDietTests.Repository.Products.ProductsStoreService;
using Xunit;

namespace ProDietTests.Repository.Patients.PatientsStoreService
{
    [Collection(nameof(PatientTestsCollection))]
    public class PatientTests
    {
        public readonly PatientsTestsFixture _fixture;
        public readonly PatientStoresService _patientStoresService;
        public PatientTests(PatientsTestsFixture fixture)
        {
            _fixture = fixture;
            _patientStoresService = new PatientStoresService(fixture.Context);
        }

        [Fact]
        public async Task GetAllPatients_WhenAllDataIsCorrect_ReturnsPatients()
        {

            var returnedPatients= await _patientStoresService.GetAllPatients();

            returnedPatients.Should().HaveCount(3);
        }

        [Fact]
        public async Task AddPatient_WhenAllDataIsCorrect_PatientCreated()
        {
            var patient = new Fixture().Customize(new PatientCustomization()).Create<Patient>();
            await _patientStoresService.AddPatient(patient);
            var patients= _fixture.Context.Patients.ToList();
            patients.Should().HaveCount(4);
        }

        [Fact]
        public async Task DeletePatient_WhenAllDataIsCorrect_PatientDeleted()
        {
            await _patientStoresService.DeletePatient(PatientsTestsFixture.Patient1Id);
            var patients = _fixture.Context.Patients.ToList();
            patients.Should().HaveCount(3);
        }

        [Fact]
        public async Task CheckPatientOwner_WhenOwnerExists_ReturnsTrue()
        {
            var response = await _patientStoresService.CheckOwner(PatientsTestsFixture.ExistingOwnerId, PatientsTestsFixture.Patient1Id); ;

            response.Should().BeTrue();
        }

        [Fact]
        public async Task CheckPatientOwner_WhenOwnerNotExists_ReturnsFalse()
        {
            var response = await _patientStoresService.CheckOwner(PatientsTestsFixture.NotExistingOwnerId, PatientsTestsFixture.Patient2Id); ;

            response.Should().BeFalse();
        }

        [Fact]

        public async Task GetAllUsersPatients_WhenAllDataIsCorrect_ReturnsPatients()
        {
            var returnedPatients = await _patientStoresService.GetAllUsersPatients(PatientsTestsFixture.PatientCreator);

            returnedPatients.Should().HaveCount(2);
        }



    }
}
