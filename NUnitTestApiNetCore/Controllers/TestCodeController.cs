using ApiNetCore.Controllers;
using NUnit.Framework;

namespace NUnitTestApiNetCore
{
    public class TestCodeController
    {
        [Test]
        public void GetCodeController()
        {
            CodeController home = new CodeController();
            string result = home.GetShowMeTheCode();
            Assert.IsNotNull(result);
        }
    }
}
