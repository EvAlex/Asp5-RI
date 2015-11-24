using Asp5RIWebsite.Controllers;
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
            var controller = new CompaniesController();

            //  act
            var response = controller.Get();

            Assert.NotNull(response);
        }
    }
}
