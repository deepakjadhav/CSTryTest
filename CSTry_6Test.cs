using CSTry_5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSTryTest
{
    /// <summary>
    /// Summary description for CsTry_5Test
    /// </summary>
    [TestFixture]
    public class CsTry_6Test
    {
        [Test]
        public void TestProperties()
        {
            var obj = new CSTry_6.Properties("test",40,"male");
            Assert.AreEqual(obj.Description.Length > 0, true);
            Assert.AreEqual(obj.Description, @"test 40 male");
        }

        [Test]
        public void TestStaticHelper()
        {
            var obj = new CSTry_6.Properties("test", 40, "male");
            Assert.AreEqual(obj.CallHelper().Length > 0, true);
            Assert.AreEqual(obj.CallHelper(), @"helper");

        }

        [Test]
        public void TestAnotherClass()
        {
            var obj = new CSTry_6.Properties("test", 40, "male");
            Assert.AreEqual(obj.CallAnother().Length > 0, true);
            Assert.AreEqual(obj.CallAnother(), @"dependant");
        }

        [Test]
        public void TestStringManupulation()
        {
            var obj = new CSTry_6.Properties("test", 40, "male");
            Assert.AreEqual(obj.State.Length > 0, true);
            Assert.AreEqual(obj.State, @"tx");
        }

        [Test]
        public void TestExceptionConditionNotMatching()
        {
            var obj = new CSTry_6.ExceptionUseCase();
            Assert.Throws<Exception>(() => obj.MathError());            
        }

        [Test]
        public void TestExceptionConditionMatching()
        {
            var obj = new CSTry_6.ExceptionUseCase();
            Assert.AreEqual(obj.InvalidError().Length > 0, true);
            Assert.AreEqual(obj.InvalidError(), @"error");
        }

        [Test]
        public void TestNameOfProperties()
        {
            var obj = new CSTry_6.Properties("test", 40, "male");
            Assert.AreEqual(nameof(obj.Name), "Name");            
        }

    }
}
