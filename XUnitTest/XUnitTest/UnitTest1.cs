using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

        }


        [Theory]
        [InlineData(5, 2, 3)]
        public void Test2(int expected, int n1, int n2)
        {
            Assert.Equal(expected, n1 + n2);
        }


    }
}
