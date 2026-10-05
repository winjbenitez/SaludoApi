using Microsoft.AspNetCore.Mvc;
using SaludoApi.Controllers;

namespace SaludoApi.Tests
{
    public class SaludoControllerTests
    {
        [Fact]
        public void GetSaludo_DebeRetornarOk()
        {
            // Arrange
            var controller = new SaludoController();

            // Act
            var resultado = controller.GetSaludo();

            // Assert
            Assert.IsType<OkObjectResult>(resultado);
        }
    }
}