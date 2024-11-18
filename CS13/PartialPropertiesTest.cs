using Xunit;

namespace CS13
{
    public class PartialPropertiesTest
    {
        [Fact]
        public void PartialProperty()
        { 
            var sut = new PartialProperties();
            Assert.Equal(42, sut.MyProperty);
        }
    }
}
