using Apple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApple
{
    [TestFixture]
    public class TestAppleGetter
    {
        [Test]
        public void GetAppleTest()
        {
            AppleGetter apple = new AppleGetter();
            Assert.AreEqual("Apple", apple.GetApple());
        }
    }
}
