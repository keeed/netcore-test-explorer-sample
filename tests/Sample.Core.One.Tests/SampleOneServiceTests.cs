using System;
using Xunit;

namespace Sample.Core.One.Tests
{
    public class SampleOneServiceTests
    {
        public class On_SampleMethod
        {
            [Fact]
            public void Should_Return_True()
            {
                // Given:
                var sut = new SampleOneService();

                // When:
                var result = sut.SomeMethod();

                // Then:
                Assert.True(result);
            }
        }
    }
}
