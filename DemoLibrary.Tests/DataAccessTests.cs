using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newTestPerson = new PersonModel { FirstName = "Pebble", LastName = "Cat" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newTestPerson);
            
            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newTestPerson, people);
        }

        [Theory]
        [InlineData("Pebble", "", "LastName")]
        [InlineData("", "Cat", "FirstName")]


        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newTestPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newTestPerson));
        }


    }
}
