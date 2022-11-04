using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using AviaTick.Controllers;
using AviaTick.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.Options;

namespace AviaTick.Tests
{
    public class AircraftControllerTest
    {
        [Fact]
        public void DetailsView()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AviaTickDbContext>();
            optionsBuilder.UseSqlServer("Server= DESKTOP-H9T34QQ\\SQLEXPRESS01; Database=AviaTickDb; Trusted_Connection=True; MultipleActiveResultSets=true");

            var controller = new AircraftController(new AviaTickDbContext(optionsBuilder.Options));
            
            var result = controller.Details(1);
            Assert.NotNull(result);
        }

        [Fact]
        public void Create_ReturnsViewResult()
        {
            AviaTickDbContext context = null;
            var controller = new AircraftController(context);

            var result = controller.Create();

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewData.Model);
        }

        [Fact]
        public void Test1()
        {
            /*var options = new DbContextOptionsBuilder<AviaTickDbContext>()
                .UseInMemoryDatabase(databaseName: "AviaTickDb")
                .Options;

            using(var context = new AviaTickDbContext(options))
            {
                context.Aircraft.Add(new Aircraft { Id = 2, Name = "Boeing", SeatsNumber = 300 });
                context.SaveChanges();
            }

            /*    using(var context = new AviaTickDbContext(options))
                {
                    List<Aircraft> aircraft = context.GetAll
                }*/
            var mockRepo = new Mock<AviaTickDbContext>();
            mockRepo.Setup(repo => repo.Aircraft);
            var controller = new AircraftController(mockRepo.Object);
           // controller.ModelState.AddModelError("Name", "Name is required");

            var result = controller.Index;
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewData.Model);
            mockRepo.Verify();
        }
    }
}
