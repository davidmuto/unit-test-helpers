using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelpers
{
    public class NumAssert
    {
        #region [LessThan]
        
        public static void IsLessThan(int referenceValue, int compareValue, string message = null)
        {
            IsLessThan((double)referenceValue, (double)compareValue, message);
        }

        public static void IsLessThan(float referenceValue, float compareValue, string message = null)
        {
            IsLessThan((double)referenceValue, (double)compareValue, message);
        }

        public static void IsLessThan(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue >= referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [LessThanOrEqual]

        public static void IsLessThanOrEqual(int referenceValue, int compareValue, string message = null)
        {
            IsLessThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        public static void IsLessThanOrEqual(float referenceValue, float compareValue, string message = null)
        {
            IsLessThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        public static void IsLessThanOrEqual(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue > referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [GreaterThan]

        public static void IsGreaterThan(int referenceValue, int compareValue, string message = null)
        {
            IsGreaterThan((double)referenceValue, (double)compareValue, message);
        }

        public static void IsGreaterThan(float referenceValue, float compareValue, string message = null)
        {
            IsGreaterThan((double)referenceValue, (double)compareValue, message);
        }

        public static void IsGreaterThan(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue <= referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [GreaterThan]

        public static void IsGreaterThanOrEqual(int referenceValue, int compareValue, string message = null)
        {
            IsGreaterThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        public static void IsGreaterThanOrEqual(float referenceValue, float compareValue, string message = null)
        {
            IsGreaterThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        public static void IsGreaterThanOrEqual(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue < referenceValue)
            {
                ThrowException(message);
            }
        }

        private static void ThrowException(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = "IsLessThan Failed";
            }

            throw new AssertFailedException(message);
        }

        #endregion
    }
}
