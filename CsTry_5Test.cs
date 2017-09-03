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
    public class CsTry_5Test
    {
        [Test]
        public void TestCallerInformation()
        {
            string tracelog = new CallerInformation().ReturnCallerInformation();
            Assert.AreEqual(tracelog.Length > 0, true);
            Assert.AreEqual(tracelog, @"TestCallerInformation - C:\deepak\CSDemo\CSTry\CSTryTest\CSTryTest\CsTry_5Test.cs - 21");

        }

        [Test]
        public void TestAsyncProgramming()
        {
            var taskresult =  new AsyncProgramming().MultipleWebCalls();
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(1==1, true);
            
        }

        [Test]
        public void TestAsyncProgrammingWhenAll()
        {
            var taskresult = new AsyncProgramming().MultipleWebCallsWithWhenAll();
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(1 == 1, true);
            
        }

        [Test]
        public void TestAsyncProgrammingWhenAny()
        {
            var taskresult = new AsyncProgramming().MultipleWebCallsWithWhenAny();
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(1 == 1, true);
            
        }

        [Test]
        public void TestCancelAsyncProgrammingSingle()
        {
            var obj = new CancelAsyncProgramming();

            var taskresult = obj.SingleWebCall();
            //Thread.Sleep(1000);

            obj.CancelAsync();            
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(taskresult.Result == "canceled", true);
            Assert.AreEqual(1 == 1, true);
            
        }

        [Test]
        public void TestCancelAsyncProgrammingMultiple()
        {
            var obj = new CancelAsyncProgramming();

            var taskresult = obj.MultipleWebCall();
            //Thread.Sleep(1000);

            obj.CancelAsync();
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(taskresult.Result == "canceled", true);
            Assert.AreEqual(1 == 1, true);
            

        }

        [Test]
        public void TestCancelAfterAsyncProgrammingMultiple()
        {
            var obj = new CancelAsyncProgramming();

            var taskresult = obj.MultipleWebCallCancelAfter();
            
            Assert.AreEqual(taskresult.Result.Length > 0, true);
            Assert.AreEqual(taskresult.Result == "canceled", true);
            Assert.AreEqual(1 == 1, true);
            
        }
        [Test]
        public void TestCancelMultipleWebCallCancelAfterAnyone()
        {
            var obj = new CancelAsyncProgramming();

            var taskresult = obj.MultipleWebCallCancelAfterAnyone();

            Assert.AreEqual(taskresult.Result.Length > 0, true);            
            Assert.AreEqual(1 == 1, true);
            
        }
    }
}
