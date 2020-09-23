using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_UnitTesting
{
    [TestClass]
    public class StockManagerTests
    {
        [TestMethod]

        public void WhenAddingNewPerfume_StockWasUpdated()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Baccarat");
            StockManager manager = new StockManager();


            //Act
            manager.AddPerfume(perfume1);


            //Assert

            Assert.IsTrue(manager.IsPerfumeInStock("Baccarat"));
        }

        [TestMethod]

        public void WhenAddingExistentPerfume_StockWasUpdated()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Baccarat");
            StockManager manager = new StockManager();
            Perfume perfume2 = new Perfume("Baccarat");
            manager.AddPerfume(perfume1);

            //Act
            manager.AddPerfume(perfume2);


            //Assert

            perfume1.Quantity.ShouldBe(2);

        }


        [TestMethod]

        public void WhenAddingTwoPerfumes_StockWasUpdated()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Baccarat");
            StockManager manager = new StockManager();
            Perfume perfume2 = new Perfume("Santal");
            manager.AddPerfume(perfume1);

            //Act
            manager.AddPerfume(perfume2);


            //Assert

            manager.IsPerfumeInStock("Baccarat").ShouldBeTrue();
            manager.IsPerfumeInStock("Santal").ShouldBeTrue();
        }

        [TestMethod]

        public void WhenDeletingAPerfumeWIthBigStock_StockWasDecreased()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Santal");
            Perfume perfume2 = new Perfume("Santal");
            StockManager manager = new StockManager();
            manager.AddPerfume(perfume1);
            manager.AddPerfume(perfume2);


            //Act
            manager.DeletePerfume(perfume2);


            //Assert
            manager.IsPerfumeInStock("Santal").ShouldBeTrue();
        }


        [TestMethod]
        public void WhenDeletingLastItemFromStock_StockWasUpdated()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Santal");

            StockManager manager = new StockManager();
            manager.AddPerfume(perfume1);



            //Act
            manager.DeletePerfume(perfume1);


            //Assert
            manager.IsPerfumeInStock("Santal").ShouldBeFalse();
        }

        [TestMethod]
        public void WhenDeletingNonExistingItem_ShouldThrowEx()
        {
            //Arrange
            Perfume perfume1 = new Perfume("Santal");

            StockManager manager = new StockManager();
 
            //Act
            Action func = ()=> 
            manager.DeletePerfume(perfume1);


            //Assert
            func.ShouldThrow<Exception>();
               
        }

    }
}
