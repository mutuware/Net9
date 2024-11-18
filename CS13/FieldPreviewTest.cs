using Xunit;

namespace CS13
{
    public class FieldPreviewTest
    {
        [Fact]
        public void WidgetCount_Assigned()
        {
            var sut = new FieldPreview();
            sut.WidgetCount = 15;
            Assert.Equal(15, sut.WidgetCount);
        }

        [Fact]
        public void WidgetCount_BelowMin()
        {
            var sut = new FieldPreview();
            sut.WidgetCount = 5;
            Assert.Equal(10, sut.WidgetCount);
        }
    }

    public class FieldPreview
    {
        private const int minCount = 10;

        public int WidgetCount
        {
            get;
            set => field = (value >= minCount) ? value : minCount;
        }
    }
}
