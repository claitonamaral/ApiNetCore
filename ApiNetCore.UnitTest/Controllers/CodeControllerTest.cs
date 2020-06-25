using ApiNetCore.Controllers;
using NUnit.Framework;

namespace ApiNetCoreUnitTest
{
    public class CodeControllerTest
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
