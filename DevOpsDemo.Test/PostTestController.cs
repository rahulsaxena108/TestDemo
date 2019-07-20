using DevOpsDemo.Controllers;
using DevOpsDemo.Models;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace DevOpsDemo.Test
{
    public class PostTestController
    {
        private PostRepository repository;
        public PostTestController()
        {
            repository = new PostRepository();
        }
        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.NotNull(result);
        } 
    }
}