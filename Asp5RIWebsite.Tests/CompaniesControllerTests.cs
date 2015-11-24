using Asp5RIWebsite.Controllers;
using Asp5RIWebsite.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Asp5RIWebsite.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class CompaniesControllerTests
    {
        [Fact]
        public void Get()
        {
            //  arrange
            var storage = new TestDataStorage();
            var controller = new CompaniesController(storage);
            var expected = storage.GetCompanies();

            //  act
            var actual = controller.Get();

            Assert.NotNull(actual);
            Assert.Equal(expected.Length, actual.Count());
            Assert.All(actual, a => Assert.Equal(expected.Count(c => c.Id == a.Id), 1));
            Assert.All(actual, a => Assert.Equal(expected.First(c => c.Id == a.Id).Name, a.Name));
        }
    }
}
