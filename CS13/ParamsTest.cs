using Xunit;

namespace CS13
{
    public class ParamsTest
    {
        [Fact]
        public void ParamsCollectionArgument()
        {
            var sut = new Params();
            var actual = sut.Join('a', 'b', 'c');
            Assert.Equal("a-b-c-", actual);
        }

        [Fact]
        public void ParamsCollectionArgumentMultiple()
        {
            var sut = new Params();
            var actual = sut.JoinFirst('a', 'b', 'c', 'd');
            Assert.Equal("ab-c-d-", actual);
        }

        [Fact]
        public void ParamsCollectionGeneric()
        {
            var sut = new Params();
            var actual = sut.OmitLast(1, 2, 3);
            Assert.Equal(2, actual.Count);
            Assert.Equal(1, actual[0]);
            Assert.Equal(2, actual[1]);
        }
    }
}