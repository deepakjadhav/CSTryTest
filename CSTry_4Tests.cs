using CSTry_4;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTryTest
{
    [TestFixture]
    public class CSTry_4Tests
    {

        [Test]
        public void TestDynamicsDefineMe()
        {
            Assert.AreEqual(new Dynamics().DefineMe(4) , "i am 4");
            Assert.AreEqual(new Dynamics().DefineMe("test"), "i am test");
            Assert.AreEqual(new Dynamics().DefineMe(Boolean.Parse("true")), "not found");
        }

        [Test]
        public void TestDynamicsVerifyMe()
        {
            Assert.AreEqual(new Dynamics().VerifyObject("test"), "test");
            Assert.AreEqual(new Dynamics().VerifyString("test"), "test");
            Assert.AreEqual(new Dynamics().VerifyDynamic("test"), "test");
        }
    }
}
