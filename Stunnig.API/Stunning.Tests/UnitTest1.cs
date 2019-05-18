using Microsoft.AspNetCore.Mvc;
using Stunnig.API.Controllers;
using Stunning.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Stunning.Tests
{
    public class UnitTest1
    {

        HomeController homeController;



        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Fact]
        public void BuscaCargoInexistente()
        {
            // Act
            var listaZerada = homeController.Get("CargoQueNaoExiste");

            // Assert
            Assert.Empty(listaZerada);
        }
    }
}
