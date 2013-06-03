using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelpers.Tests
{
    [TestClass]
    public class AnonAssertTests
    {
        private object _subject = new
        {
            Source = "http://www.davidmuto.com/",
            Prop1 = 1,
            Prop2 = 2.0
        };

        #region [PropCount/Names]
        
        [TestMethod]
        public void AnonAssert_PropCount_ValidatesNumberOfProperties()
        {
            AnonAssert.PropCount(3, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_PropCount_FailsWithWrongNumberOfProperties()
        {
            AnonAssert.PropCount(1, this._subject);
        }

        [TestMethod]
        public void AnonAssert_PropNames_ValidatesPropertyNames()
        {
            AnonAssert.PropNames(new string[] { "Source", "Prop1", "Prop2" }, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_PropCount_FailsWithWrongPropertyNames()
        {
            AnonAssert.PropNames(new string[] { "Source", /*ISSUE*/"prop1", "Prop2" }, this._subject);
        }

        #endregion

        #region [HasValues]

        [TestMethod]
        public void AnonAssert_HasValues_ValidatesActualHasSuppliedValues()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/"
            };

            AnonAssert.HasValues(expected, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_HasValues_FailsWhenActualValueIsNotSuppliedValue()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com"
            };

            AnonAssert.HasValues(expected, this._subject);            
        }

        [TestMethod]
        public void AnonAssert_HasValues_WorksWithAllValuesSupplied()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/",
                Prop1 = 1,
                Prop2 = 2.0
            };

            AnonAssert.HasValues(expected, this._subject);
        }

        #endregion

        #region [AreEqual]
        
        [TestMethod]
        public void AnonAssert_AreEqual_ValidatesExpectedAndActualValues()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/",
                Prop1 = 1,
                Prop2 = 2.0
            };

            AnonAssert.AreEqual(expected, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_AreEqual_FailsWhenSuppliedValueIsMissing()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/",
                NotFound = "Some Value"
            };

            AnonAssert.AreEqual(expected, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_AreEqual_FailsWhenActualValueIsMissing()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/",
                Prop1 = 1
            };

            AnonAssert.AreEqual(expected, this._subject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AnonAssert_AreEqual_FailsWhenActualValueIsDifferent()
        {
            var expected = new
            {
                Source = "http://www.davidmuto.com/",
                Prop1 = 1,
                Prop2 = 2 /* Not a double this time... */
            };

            AnonAssert.AreEqual(expected, this._subject);
        }

        #endregion
    }
}
