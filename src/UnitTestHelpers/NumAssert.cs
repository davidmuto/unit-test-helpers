using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelpers
{
    /// <summary>
    /// A class that exposes some asserts for testing numeric values
    /// </summary>
    public class NumAssert
    {
        #region [LessThan]
        
        /// <summary>
        /// Verifies that the compare value is less than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThan(int referenceValue, int compareValue, string message = null)
        {
            IsLessThan((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is less than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThan(float referenceValue, float compareValue, string message = null)
        {
            IsLessThan((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is less than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThan(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue >= referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [LessThanOrEqual]

        /// <summary>
        /// Verifies that the compare value is less than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThanOrEqual(int referenceValue, int compareValue, string message = null)
        {
            IsLessThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is less than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThanOrEqual(float referenceValue, float compareValue, string message = null)
        {
            IsLessThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is less than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsLessThanOrEqual(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue > referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [GreaterThan]

        /// <summary>
        /// Verifies that the compare value is greater than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThan(int referenceValue, int compareValue, string message = null)
        {
            IsGreaterThan((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is greater than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThan(float referenceValue, float compareValue, string message = null)
        {
            IsGreaterThan((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is greater than the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThan(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue <= referenceValue)
            {
                ThrowException(message);
            }
        }

        #endregion

        #region [GreaterThan]

        /// <summary>
        /// Verifies that the compare value is greater than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThanOrEqual(int referenceValue, int compareValue, string message = null)
        {
            IsGreaterThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is greater than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThanOrEqual(float referenceValue, float compareValue, string message = null)
        {
            IsGreaterThanOrEqual((double)referenceValue, (double)compareValue, message);
        }

        /// <summary>
        /// Verifies that the compare value is greater than or equal to the reference value
        /// </summary>
        /// <param name="referenceValue">The value to compare against</param>
        /// <param name="compareValue">The value to compare</param>
        /// <param name="message">Optional message to display when this assertion fails</param>
        public static void IsGreaterThanOrEqual(double referenceValue, double compareValue, string message = null)
        {
            if (compareValue < referenceValue)
            {
                ThrowException(message);
            }
        }               

        #endregion
        
        private static void ThrowException(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = "IsLessThan Failed";
            }

            throw new AssertFailedException(message);
        }
    }
}
