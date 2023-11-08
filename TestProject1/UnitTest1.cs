using SampleNetSolution;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Program.TestMe();
            Assert.IsTrue(actual);
        }
    }
}