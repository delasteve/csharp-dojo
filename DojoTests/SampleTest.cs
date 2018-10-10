using Dojo;
using Xunit;

namespace DojoTests
{
    public class SampleTest
    {
        [Fact]
        public void DoThing_ReturnEmptyString()
        {
            var sample = new Sample();

            var result = sample.DoThing();

            Assert.Equal("", result);
        }
    }
}
