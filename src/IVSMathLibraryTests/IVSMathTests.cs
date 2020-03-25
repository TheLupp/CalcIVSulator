﻿using System;
using IVSMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IVSMathLibraryTests
{
    [TestClass]
    public class IVSMathTests
    {
        // Prepare
        double precision = 0.0000001f;

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void NumberValidation_Overflow_ReturnExeptions()
        {
        }

        [TestMethod]
        public void Add_Calculation_ReturnsEqual()
        {

        }

        [TestMethod]
        public void Substract_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Multiply_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ReturnExeptions()
        {
        }

        [TestMethod]
        public void Divide_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Root_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Power_CalculationWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(8, IVSMath.Power(2, 3), 0);
            Assert.AreEqual(0, IVSMath.Power(0, 5), 0);
        }

        public void Power_CalculationNegativeWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(-8, IVSMath.Power(-2, 3), 0);
            Assert.AreEqual(-16, IVSMath.Power(-2, 4), 0); // Brackets are not going to be implemented

            Assert.AreEqual((1 / 8), IVSMath.Power(2, -3), precision);
            Assert.AreEqual((1 / 16), IVSMath.Power(2, -4), precision);
            Assert.AreEqual(-(1 / 8), IVSMath.Power(-2, -3), precision);
            Assert.AreEqual(-(1 / 16), IVSMath.Power(-2, -4), precision);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Power_ArithmeticException_ReturnExeptions()
        {
            Assert.AreEqual(0, IVSMath.Power(0, -5), 0);
        }

        public void Power_CalculationDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((25 / 4), IVSMath.Power(2.5, 2), precision);
        }

        public void Power_CalculationNegativeDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((4 / 25), IVSMath.Power(2.5, -2), precision);
            Assert.AreEqual(-(25 / 4), IVSMath.Power(-2.5, 2), precision);
            Assert.AreEqual(-(4 / 25), IVSMath.Power(-2.5, -2), precision);
        }

        public void Power_CalculationRationalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Power(Math.PI, 2), precision);
        }

        [TestMethod]
        public void Inverse_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Sine_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Cosine_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Tangent_Calculation_ReturnsTrue()
        {
        }
    }
}
