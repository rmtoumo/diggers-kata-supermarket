using Supermarket.Shelves;
using Xunit;

namespace Supermarket.Tests
{
    public class Step4
    {
        [Fact]
        public void Builder_ShouldBuildDIYSection_When_DIYAsked()
        {
            var expectedSectionType = ShelfType.DIY;
            var actualSection = Builder.BuildShelf(expectedSectionType);

            Assert.Equal(expectedSectionType, actualSection.Type);
        }

        [Fact]
        public void Builder_ShouldBuildLuxurySection_When_LuxuryAsked()
        {
            var expectedSectionType = ShelfType.Luxury;
            var actualSection = Builder.BuildShelf(expectedSectionType);

            Assert.Equal(expectedSectionType, actualSection.Type);
        }

        [Fact]
        public void Builder_ShouldBuildVegetableSection_When_VegetableAsked()
        {
            var expectedSectionType = ShelfType.Vegetable;
            var actualSection = Builder.BuildShelf(expectedSectionType);

            Assert.Equal(expectedSectionType, actualSection.Type);
        }
    }
}
