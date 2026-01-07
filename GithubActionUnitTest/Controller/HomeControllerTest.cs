using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;
using GithubActionTest.Controllers;
using GithubActionTest.Models;

namespace GithubActionUnitTest
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var logger = NullLogger<HomeController>.Instance;
            var controller = new HomeController(logger);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName); // uses default view
        }

        //[Fact]
        //public void About_SetsMessageAndReturnsView()
        //{
        //    // Arrange
        //    var logger = NullLogger<HomeController>.Instance;
        //    var controller = new HomeController(logger);

        //    // Act
        //    var result = controller.About();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    Assert.True(controller.ViewData.ContainsKey("Message"));
        //    Assert.Equal("Your application description page.", controller.ViewData["Message"]);
        //    Assert.Null(viewResult.ViewName); // uses default view
        //}

        //[Fact]
        //public void Privacy_ReturnsViewResult()
        //{
        //    // Arrange
        //    var logger = NullLogger<HomeController>.Instance;
        //    var controller = new HomeController(logger);

        //    // Act
        //    var result = controller.Privacy();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    Assert.Null(viewResult.ViewName); // uses default view
        //}

        //[Fact]
        //public void Error_ReturnsViewResultWithErrorViewModelContainingRequestId()
        //{
        //    // Arrange
        //    var logger = NullLogger<HomeController>.Instance;
        //    var controller = new HomeController(logger);

        //    // Ensure Activity.Current is null so HttpContext.TraceIdentifier is used.
        //    Activity.Current = null;

        //    var httpContext = new DefaultHttpContext();
        //    httpContext.TraceIdentifier = "trace-123";
        //    controller.ControllerContext = new ControllerContext
        //    {
        //        HttpContext = httpContext
        //    };

        //    // Act
        //    var result = controller.Error();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var model = Assert.IsType<ErrorViewModel>(viewResult.Model);
        //    Assert.Equal("trace-123", model.RequestId);
        //}
    }
}