using GeoDraw.App.Services;

namespace GeoDraw.UnitTests.Services
{
    public class MockObjectSelectionServiceShould
    {
        [Fact]
        public async Task ChooseAValidThing()
        {
            //Arrange
            var mock = new MockObjectSelectionService();

            //Act
            var selectedThing = await mock.GetThing();

            //Assert
            Assert.Contains(selectedThing, new[] { "snowman", "fish", "car", "star", "frog" });
        }
    }
}
