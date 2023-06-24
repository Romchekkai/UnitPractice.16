using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace UnitPractic._16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.That(calculator.Additional(20, 15) == 35);
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue() 
        {
            Assert.That(calculator.Multiplication(2, 4) == 8);
        }
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.That(calculator.Subtraction(10, 4) == 6);
        }
        [Test]
        public void DivisionMustReturnCorrectValue() 
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(2,0));
        }
    }
}
