using System;
using Xunit;
using BetManagement;
using BetManagement.Interface;
using Moq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public IServices service;

        [Fact]
        public void TestCreateMatch()
        {
            //public IServices service;
            //var service = new Mock<IServices>(); 
            var controller = new BetManagement.Controllers.ServiceController(service);
            var request = new BetManagement.Models.Match
            {
                ID = 1,
                TeamA = "Olympiacos",
                TeamB = "Arsenal",
                Sport = "Football",
                Description = "Olympiacos - Arsenal",
                MatchDate = "123"
                //MatchTime = null
            
                
            };

            var result = controller.CreateMatch(request);
            Assert.NotNull(result);

        }
    }
}
