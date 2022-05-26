using WebApiNet6Lib;

namespace WebApiNet6LibTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var lib = new Class1();
            var expected = "Foo";
            var result = lib.Foo();
            Assert.Equal(expected, result);
        }
    }
}