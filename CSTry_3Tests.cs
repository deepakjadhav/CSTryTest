using System;
using NUnit;
using Moq;
using NUnit.Framework;
using CSTry_3;
using System.Collections.Generic;

namespace CSTryTest
{
    [TestFixture]
    public class CSTry_3Tests
    {
        [Test]
        public void TestExtensionStringOnInt()
        {
            var num = 3;

            Assert.AreEqual(num.ConvertString("this number is "), "this number is 3");
        }

        [Test]
        public void TestExtensionStringOnClass()
        {
            ExtendMe extendme = new ExtendMe("john","winterfell");

            Assert.AreEqual(extendme.ConvertString(), "johnwinterfell");
        }

        [Test]
        public void TestFuncOnAdd()
        {
            Delegates delegates = new Delegates();
            
            Assert.AreEqual(delegates.AddTwoNumber(4,5), 9);
        }

        [Test]
        public void TestFuncOnSubtract()
        {
            Delegates delegates = new Delegates();

            Assert.AreEqual(delegates.SubtractTwoNumber(5, 4), 1);
        }

        [Test]
        public void TestFuncOnString()
        {
            Delegates delegates = new Delegates();

            Assert.AreEqual(delegates.ParseInt(5), "this is string 5");
        }

        [Test]
        public void TestFuncOnCalculate_1()
        {
            Delegates delegates = new Delegates();

            Assert.AreEqual(delegates.Calculate(10, MultipleTwoNumbers),60);
        }

        [Test]
        public void TestFuncOnCalculate_2()
        {
            Delegates delegates = new Delegates();

            Assert.AreEqual(delegates.Calculate(10, Square), 110);
        }

        [Test]
        public void TestExpressionTreePrime()
        {
            ExpressionTrees expressiontrees = new ExpressionTrees();
            Assert.AreEqual(expressiontrees.CheckIfPrime(1), false);
            Assert.AreEqual(expressiontrees.CheckIfPrime(2), true);
            Assert.AreEqual(expressiontrees.CheckIfPrime(3), true);
            Assert.AreEqual(expressiontrees.CheckIfPrime(15), false);
            Assert.AreEqual(expressiontrees.CheckIfPrime(5), true);
        }

        [Test]
        public void TestExpressionTreeIfExists()
        {
            ExpressionTrees expressiontrees = new ExpressionTrees();
            Assert.AreEqual(expressiontrees.CheckIfexists(1,new List<int>{1,2,4,5}), true);
            Assert.AreEqual(expressiontrees.CheckIfexists(6, new List<int> { 1, 2, 4, 5 }), false);
        }


        private int MultipleTwoNumbers(int x, int y)
        { return (x * y); }

        private int Square(int x, int y)
        { return (x * x); }
    }
}
