using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.SupplierDtos;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Controllers;
using Xunit;

namespace WebApi.Test
{
    public class SupplierControllerTest
    {
        [Fact]
        public async Task GetSuppliers_Returns_The_Correct_Number_Of_Records()
        {
            int count = 5;
            //Arrange
            var fakesuppliers = A.CollectionOfDummy<SupplierDto>(count).AsEnumerable();
            var supplierService = A.Fake<ISupplierService>();
            A.CallTo(() => supplierService.GetSupplier()).Returns(Task.FromResult(fakesuppliers));
            var controller = new SupplierController(supplierService);

            //Act
            var actionResult = await controller.GetSuppliers();

            //Assert

            var result = actionResult as OkObjectResult;
            var supplierResult = result.Value as IEnumerable<SupplierDto>;
            Assert.Equal(count, supplierResult.Count());
        }

        [Fact]
        public async Task Test_Invalid_SupplierId()
        {
            //Arrange
            var supplierService = A.Fake<ISupplierService>();
            var controller = new SupplierController(supplierService);

            //Act
            var actionResult = await controller.GetSupplier(-1);

            //Assert
            var result = actionResult as BadRequestObjectResult;
            var supplierResult = result.Value as ErrorResult;
            Assert.NotNull(supplierResult);
        }
    }
}
