using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(10, 7);
            Assert.AreEqual(17, testResult, "I expected the test 10 + 7 would equal 17.");
        }
    }
}
