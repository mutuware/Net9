using Xunit;

namespace Libraries
{
    public class TimeSpanTest
    {
        [Fact]
        public void FromSecondsInt()
        {
            var ts = TimeSpan.FromSeconds(1, 2, 3); // new in .Net 9
            Assert.Equal(1, ts.Seconds);
            Assert.Equal(2, ts.Milliseconds);
            Assert.Equal(3, ts.Microseconds);
        }
    }
}
