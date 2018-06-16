using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TreehouseDefense; 

namespace TestTreehouseDefense
{
    public class MapTests
    {
        [Fact]
        public void OnMapTest()
        {
            // Arrange
            int y = 5;
            int x = 6;

            int width = 8;
            int height = 9;

            // Act

            var map = new Map(width, height);
            var point = new Point(x, y);

            // Assert

            Assert.True(map.OnMap(point)); 
           
        }

        [Fact]
        public void MapToSmall()
        {
            // Arrange
            var width = 0;

            var height = 0;

            // Act & Assert


            Assert.Throws<ArgumentOutOfRangeException>(() =>new Map(width, height));

        }

    }
}
