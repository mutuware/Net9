using Xunit;

namespace CS13
{
    public class ImplicitIndexAccessTest
    {
        [Fact]
        public void IndexerTest()
        {
            var sut = new ImplicitIndex()
            {
                MyInts =
                {
                    [^1] = 1,
                    [^2] = 2,
                    [^3] = 3,
                }
            };

            Assert.Equal(3, sut.MyInts.Length);
            Assert.Equal(3, sut.MyInts[0]);
            Assert.Equal(2, sut.MyInts[1]);
            Assert.Equal(1, sut.MyInts[2]);
        }
    }
}
