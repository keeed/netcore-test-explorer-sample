using System;
using Xunit;

namespace Sample.Core.Three.Tests
{
    public class SampleThreeServiceTests
    {
        public class On_SomeMethod
        {
            [Fact]
            public void Should_Return_True()
            {
                // Given:
                var sut = new SampleThreeService();

                // When:
                var result = sut.SomeMethod();

                // Then:
                Assert.True(result);
            }
        }
    }
}
