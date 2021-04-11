using System;
using Xunit;
using BetManagement;
using BetManagement.Interface;



namespace XUnitTest
{
    public class UnitTest1 
    {
        private IServices service;
        [Fact]
        public void TestCreateMatch()
        {
            var controller = new BetManagement.Controllers.ServiceController(service);
            var request = new BetManagement.Models.Match
            {
                ID = 1,
                TeamA = "Olympiacos",
                TeamB = "Arsenal",
                Sport = "Football",
                Description = "Olympiacos - Arsenal"
            };

            IAsyncResult result = controller.CreateMatch(request);
            Assert.NotNull(result);

        }
    }
}
