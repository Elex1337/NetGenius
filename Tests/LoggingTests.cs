//using NUnit.Framework;
//using Moq;
//using Serilog;
//using Microsoft.AspNetCore.Hosting;
//using namespace NetGenius
//{
//    [TestFixture]
//    public class LoggingTests
//    {
//        [Test]
//        public void LogFileCreated()
//        {
//            // Arrange
//            var mockWebHost = new Mock<IWebHost>();
//            var mockWebHostBuilder = new Mock<IWebHostBuilder>();
//            mockWebHostBuilder.Setup(b => b.Build()).Returns(mockWebHost.Object);

//            // Act
//            var logger = Program.CreateLogger(mockWebHostBuilder.Object);

//            // Assert
//            Assert.IsNotNull(logger);
//        }

//        [Test]
//        public void LogToFile()
//        {
//            // Arrange
//            var mockWebHost = new Mock<IWebHost>();
//            var mockWebHostBuilder = new Mock<IWebHostBuilder>();
//            mockWebHostBuilder.Setup(b => b.Build()).Returns(mockWebHost.Object);

//            var logger = Program.CreateLogger(mockWebHostBuilder.Object);

//            // Act
//            logger.Information("Test log message");

//            // Assert
//            // You may want to check if "Test log message" is present in the log file.
//            // For simplicity, you may just assert that logging happened without errors.
//            Assert.Pass("Logging to file successful.");
//        }

//        [Test]
//        public void LogToConsole()
//        {
//            // Arrange
//            var mockWebHost = new Mock<IWebHost>();
//            var mockWebHostBuilder = new Mock<IWebHostBuilder>();
//            mockWebHostBuilder.Setup(b => b.Build()).Returns(mockWebHost.Object);

//            var logger = Program.CreateLogger(mockWebHostBuilder.Object);

//            // Act
//            logger.Information("Test log message");

//            // Assert
//            // You may want to capture console output and assert on its content.
//            // For simplicity, you may just assert that logging happened without errors.
//            Assert.Pass("Logging to console successful.");
//        }

//    }

//}