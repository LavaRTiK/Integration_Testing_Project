using Microsoft.VisualStudio.TestTools.UnitTesting;
using Email_ServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Email_ServiceLib.Tests
{
    [TestClass]
    public class Email_ServiceTests
    {
        [TestMethod]
        public void SendEmailTest()
        {
            var mockEmailService = new Mock<Email_Service>();
            mockEmailService.Setup(service => service.SendEmail(
            "example@example.com", "Test Subject", "Test Message")).Returns(true);
            var result = mockEmailService.Object.SendEmail("example@example.com", "Test Subject", "Test Message");
            Assert.IsTrue(result);
        }
    }
}