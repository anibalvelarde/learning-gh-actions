using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MathMachine.Test;

namespace MathMachine.Test

{

    [TestClass]

    public class CalculatorServiceTests

    {

        [TestMethod]

        public void Should_Add_when_operands_are_provided()

        {

            // arrange...

            var calcSvc = new CalculatorService();

            int op1 = 5; int op2 = 17;

            int expectedResult = 22;

 

            // act...

            var actualResult = calcSvc.Add(op1, op2);

 

            // assert...

            Assert.AreEqual(expectedResult, actualResult);

        }

 

        [TestMethod]

        public void Should_Subtract_when_operands_are_provided()

        {

            // arrange...

            var calcSvc = new CalculatorService();

            int op1 = 5; int op2 = 17;

            int expectedResult = -12;

 

            // act...

            var actualResult = calcSvc.Subtract(op1, op2);

 

            // assert...

            Assert.AreEqual(expectedResult, actualResult);

        }

 

        [TestMethod]

        public void Should_Multiply_when_operands_are_provided()

        {

            // arrange...

            var calcSvc = new CalculatorService();

            int op1 = 5; int op2 = 17;

            int expectedResult = 85;

 

            // act...

            var actualResult = calcSvc.Multiply(op1, op2);

 

            // assert...

            Assert.AreEqual(expectedResult, actualResult);

        }

 

        [TestMethod]

        public void Should_Divide_when_operands_are_provided()

        {

            // arrange...

            var calcSvc = new CalculatorService();

            int op1 = 20; int op2 = 5;

            int expectedResult = 4;

 

            // act...

            var actualResult = calcSvc.Divide(op1, op2);

 

            // assert...

            Assert.AreEqual(expectedResult, actualResult);

        }

 

        [TestMethod]

        [ExpectedException(typeof(DivideByZeroException))]

        public void Should_Throw_DivideByZero_Exception()

        {

            // Note:  the 'assert' portion is not needed since we are expecting an exception to be thrown.

            // arrange..

            var calcSvc = new CalculatorService();

 

            // act..

            calcSvc.Divide(1, 0);

        }

 

        [TestMethod]

        public void Should_Throw_DivideByZero_Exception_Alternative_1()

        {

            // Note:  the 'assert' portion is not needed since we are expecting an exception to be thrown.

            // arrange..

            var calcSvc = new CalculatorService();

 

            // act..

            Assert.ThrowsException<DivideByZeroException>(() => calcSvc.Divide(1, 0));

        }

    }

}