using System.Buffers.Text;
using System.Text;
using Xunit;

namespace Libraries
{
    public class Base64Test
    {
        [Fact]
        public void Encode()
        {
            ReadOnlySpan<byte> bytes = "abc"u8;
            var encoded = Base64Url.EncodeToString(bytes);
            Assert.Equal("YWJj", encoded);
        }

        [Fact]
        public void Decode()
        {
            ReadOnlySpan<byte> bytes = "YWJj"u8;
            var decoded = Base64Url.DecodeFromUtf8(bytes);
            var result = Encoding.UTF8.GetString(decoded, 0, decoded.Length);
            Assert.Equal("abc", result);
        }
    }
}
