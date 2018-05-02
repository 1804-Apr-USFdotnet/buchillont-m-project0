using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project0ClassLibrary;

namespace TestProjectForRestaurants
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //so here I'm supposed to test out the methods in the class library
            //let's find out if I can create a review for a restaurant 

            //arrange
            Restaurant r = new Restaurant("Dunkin' Donuts'", "1134 Sunrise Dr", "dunkindonuts@yahoo.com", "123-456-7899", 3.0 );
            Review rev = new Review();
            

            //act
            rev.rating = 3.0;
            rev.description = "Donuts are great but more variety needed.";
            r.reviews.Add(rev);

            //assert
            Assert.IsTrue(r.reviews.Contains(rev));


        }
    }
}
