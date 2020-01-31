using System;
using System.Collections.Generic;
using Xunit;

namespace SoftUniDemoTests
{
    public class DemoTests
    {
        [Fact]
        public void ExampleTest1()
        {
            Assert.Equal(5, 5);
        }

        [Fact]
        public void ExampleTest2()
        {
            var someCollection = new List<string>();
            Assert.NotNull(someCollection);
        }

        [Fact]
        public void ExampleTest3()
        {
            var someBool = false;
            Assert.False(someBool);
        }
    }
}
