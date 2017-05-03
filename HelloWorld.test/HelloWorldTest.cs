using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Data;
using HelloWorldApi.Controllers;

namespace HelloWorld.test
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void Test_Get()
        {
            //Instantiate a new HelloWorldRepository
            HelloWorldRepository hrd = new Data.HelloWorldRepository();

            //Instantiate a new HelloWorldRepository
            HelloWorldController controller = new HelloWorldApi.Controllers.HelloWorldController(hrd);
            //Arrange
            var expected = "Hello World";

            //Act
            var result = controller.Get();

            //Asset
            Assert.AreEqual(expected, result);
            
            
        }
        [TestMethod]
        public void Test_Return_Get()
        {
            //Instantiate a new HelloWorldRepository
            HelloWorldRepository hrd = new Data.HelloWorldRepository();

            //Instantiate a new HelloWorldRepository
            HelloWorldController controller = new HelloWorldApi.Controllers.HelloWorldController(hrd);
            //Arrange

            //Act
            var result = controller.Get();

            //Asset
            Assert.IsNotNull(result);
        }
    }
}
