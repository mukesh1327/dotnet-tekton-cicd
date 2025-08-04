using Xunit;

namespace Dotnet8_hello_world.Tests
{
    public class HelloTests
    {
        [Fact]
        public void HelloWorld_ReturnsExpectedString()
        {
            // Arrange
            var getRoot = () => "Hello World!";

            // Act
            var result = getRoot();

            // Assert
            Assert.Equal("Hello World!", result);
        }
    }
}
