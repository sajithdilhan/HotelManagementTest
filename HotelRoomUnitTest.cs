using CoreLibrary.Entities;
using CoreLibrary.Services;
using HotelManagementSolution.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace HotelManagementTest
{
    /// <summary>
    /// Sample Test Cases for Rooms Controller
    /// </summary>
    public class HotelRoomUnitTest
    {
        [Fact]
        public void GetAllRooms()
        {
            //Arrange
            var dataServiceMock = new Mock<IHotelRoomDataService>();
            dataServiceMock.Setup(service => service.List()).Returns((IEnumerable<IHotelRoom>)null);

            var loggerMock = new Mock<ILogger<RoomsController>>();

            var controller = new RoomsController(loggerMock.Object, dataServiceMock.Object);

            //Accept

            var result = controller.GetAllRooms();

            //Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void AssignRoom()
        {
            //Arrange
            var dataServiceMock = new Mock<IHotelRoomDataService>();
            dataServiceMock.Setup(service => service.AssignRoom()).Returns((string)null);

            var loggerMock = new Mock<ILogger<RoomsController>>();

            var controller = new RoomsController(loggerMock.Object, dataServiceMock.Object);

            //Accept

            var result = controller.AssignRoom();

            //Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void SetClean()
        {
            //Arrange
            var dataServiceMock = new Mock<IHotelRoomDataService>();
            dataServiceMock.Setup(service => service.SetClean("")).Returns(null);

            var loggerMock = new Mock<ILogger<RoomsController>>();

            var controller = new RoomsController(loggerMock.Object, dataServiceMock.Object);

            //Accept

            var resultFailed = controller.SetClean("6A");

            //Assert
            Assert.IsType<BadRequestObjectResult>(resultFailed);
        }
    }
}
