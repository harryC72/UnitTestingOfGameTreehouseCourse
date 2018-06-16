using System;
using Xunit;
using TreehouseDefense;

namespace TestTreehouseDefense
{
    public class PointTests
    {
        [Fact]
        public void PointTest()
        {
            // Arrange
            int x = 5;
            int y = 6;

            //Act
            var point = new Point(x, y);

            //Assert
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceToTest()
        {
            var point = new Point(3, 4);

            var target = new Point(0, 0);

            var expected = 5;

            var actual = point.DistanceTo(target);

            Assert.Equal(actual, expected, 2);

        }

        [Fact]
        public void DistanceToTest2()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            var expected = 0;

            var actual = point.DistanceTo(target);

            Assert.Equal(actual, expected, 2); 
 

        }

       


    }
}

