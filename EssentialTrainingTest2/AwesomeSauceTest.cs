using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTest2
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("tabasco");
            testInstance.Sauces.Add("ranch");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("ranch"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("ketchup"));
        }

    }
}