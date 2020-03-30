﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary
{
    public class IVSMath
    {
        /**
         * Returns sum of two parametrs
         * Throws OverflowException if the sum of two parametrs is bigger then double.MaxValue or lower than double.MinValue
         * @param   Augend  First number to add
         * @param   Addend  Second number to add
         * @return  Sum     Sum of two arguments
         */
        public static double Add(double augend, double addend)
        {
            if (augend > double.MaxValue - addend)                                      // if sum gets higher than double.MaxValue
                throw new System.OverflowException("The sum is too high.");
            if (addend < 0 && augend < double.MinValue - addend)                        // if sum gets lower than double.MinValue
                throw new System.OverflowException("The sum is too low.");

            double sum = checked(augend + addend);
            return sum;
        }

        /**
         * Returns difference of two parametrs
         * Throws OverflowException if the difference of two parametrs is lower then double.MinValue
         * @param   Minuend     The number that is to be subtracted from.
         * @param   Subtrahend  The number that is to be subtracted.
         * @return  Difference  Difference of two parametrs
         */
        public static double Substract(double minuend, double subtrahend)
        {
            if (minuend < double.MinValue + subtrahend)     // if difference si lower than double.MinValue 
                throw new System.OverflowException();
            if (subtrahend < 0 && minuend > double.MaxValue + subtrahend)
                throw new System.OverflowException();       // if difference is higher than double.MaxValue

            double difference = checked(minuend - subtrahend);
            return difference;
        }

        public static double Multiply(double multiplier, double multiplicand)
        {

            return 0;
        }

        public static double Divide(double dividend, double divisor)
        {
            return 0;
        }

        public static double Root(double radicand, double degree)
        {
            return 0;
        }

        public static double Power(double base_, int exponent)
        {
            return 0;
        }

        public static int Factorial(int a)
        {
            return 0;
        }

        public static double Inverse(double a)
        {
            return 0;
        }

        public static double Sine(double a)
        {
            return 0;
        }

        public static double Cosine(double a)
        {
            return 0;
        }

        public static double Tangent(double a)
        {
            return 0;
        }
    }
}
