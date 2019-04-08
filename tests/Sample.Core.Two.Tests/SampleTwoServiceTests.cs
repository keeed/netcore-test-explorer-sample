using System;
using Xunit;

namespace Sample.Core.Two.Tests
{
    public class SampleTwoServiceTests
    {
        public class On_SomeMethod
        {
            [Fact]
            public void Should_Return_True()
            {
                // Given:
                var sut = new SampleTwoService();

                // When:
                var result = sut.SampleMethod();

                // Then:
                Assert.True(result);
            }
        }
    }
}
