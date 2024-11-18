using Xunit;

namespace CS13
{
    public class UnicodePointTest
    {
        [Fact]
        public void NewlineUnicode()
        {
            var c = '\n';
            var str = $"U+{(int)c:x4}";
            Assert.Equal("U+000a", str);
        }

        [Fact]
        public void TabUnicode()
        {
            var c = '\t';
            var str = $"U+{(int)c:x4}";
            Assert.Equal("U+0009", str);
        }

        [Fact]
        public void EscapeUnicode()
        {
            var c = '\e'; // new in C#13
            var str = $"U+{(int)c:x4}";
            Assert.Equal("U+001b", str);
        }

    }
}
