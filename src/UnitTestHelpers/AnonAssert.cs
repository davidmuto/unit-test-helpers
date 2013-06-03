using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelpers
{
    /// <summary>
    /// A class that handles assertions for anonymous objects
    /// </summary>
    public class AnonAssert
    {
        /// <summary>
        /// Verifies that the object has the specified number of properties
        /// </summary>
        /// <param name="expectedCount">The expected number of properties</param>
        /// <param name="actual">The object to reflect on</param>
        /// <param name="message">Optional failure message</param>
        public static void PropCount(int expectedCount, object actual, string message = null)
        {
            message = message ?? MethodInfo.GetCurrentMethod().Name + "Failed";
            Assert.AreEqual(expectedCount, actual.GetType().GetProperties().Length, message);
        }

        /// <summary>
        /// Verifies that the specified object has all/only the supplied properties
        /// </summary>
        /// <param name="expectedNames">The expected (case-sensitive) names of all properties</param>
        /// <param name="actual">The object to reflect on</param>
        /// <param name="message">Optional failure message</param>
        public static void PropNames(string[] expectedNames, object actual, string message = null)
        {
            message = message ?? MethodInfo.GetCurrentMethod().Name + "Failed";

            var names = actual.GetType().GetProperties();
            CollectionAssert.AreEqual(
                expectedNames.OrderBy(s => s).ToArray(),
                names.Select(p => p.Name).OrderBy(s => s).ToArray(),
                message
            );
        }

        /// <summary>
        /// Validates that each of the properties in the expected object is present and equal to the same property on the actual object
        /// </summary>
        /// <param name="expected">The expected (property supplier)</param>
        /// <param name="actual">The actual object to reflect on</param>
        /// <param name="message">Optional failure message</param>
        public static void HasValues(object expected, object actual, string message = null)
        {
            var expectedFields = expected.GetType().GetProperties();
            var actualFields = actual.GetType().GetProperties();

            message = message ?? MethodInfo.GetCurrentMethod().Name + "Failed";
                        
            for (int i = 0; i < expectedFields.Length; i++)
            {
                var current = actualFields.FirstOrDefault(f => f.Name.Equals(expectedFields[i].Name));
                if (current == null) continue;

                Assert.AreEqual(expectedFields[i].GetValue(expected), current.GetValue(actual));
            }
        }

        /// <summary>
        /// Validates that all properties are the same for both expected and actual objects
        /// </summary>
        /// <param name="expected">The expected object to reflect on</param>
        /// <param name="actual">The actual object to reflect on</param>
        /// <param name="message">Optional failure message</param>
        public static void AreEqual(object expected, object actual, string message = null)
        {
            var expectedFields = expected.GetType().GetProperties();
            var actualFields = actual.GetType().GetProperties();

            message = message ?? MethodInfo.GetCurrentMethod().Name + "Failed";
            CollectionAssert.AreEqual(
                expectedFields.Select(f => f.Name).OrderBy(s => s).ToArray(),
                actualFields.Select(f => f.Name).OrderBy(s => s).ToArray()
            );
            
            for (int i = 0; i < expectedFields.Length; i++)
            {
                var current = actualFields.FirstOrDefault(f => f.Name.Equals(expectedFields[i].Name));
                if (current == null)
                {
                    throw new AssertFailedException(message);
                }

                Assert.AreEqual(expectedFields[i].GetValue(expected), current.GetValue(actual));
            }
        }

        private static void ThrowException(string message, string method)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = method + " Failed";
            }

            throw new AssertFailedException(message);
        }
    }
}
