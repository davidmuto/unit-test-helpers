using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelpers.Tests
{
    [TestClass]
    public class NumAssertTests
    {
        #region [LessThan]
        
        [TestMethod]
        public void NumAssert_LessThan_ReturnsTrueWhenIntValueIsLess()
        {            
            NumAssert.IsLessThan(5, 4);
        }

        [TestMethod]
        public void NumAssert_LessThan_ReturnsTrueWhenFloatValueIsLess()
        {
            NumAssert.IsLessThan(5.00001f, 5.0f);
        }

        [TestMethod]
        public void NumAssert_LessThan_ReturnsTrueWhenDoubleValueIsLess()
        {
            NumAssert.IsLessThan(5.0023d, 5.0022d);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_LessThan_ThrowsWhenDoubleValueIsEqualTo()
        {
            NumAssert.IsLessThan(5.0023d, 5.0023d);
            Assert.Fail("IsLessThan passed when values were equal");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_LessThan_ThrowsWhenDoubleValueIsGreaterThan()
        {
            NumAssert.IsLessThan(5.0023d, 5.0123d);
            Assert.Fail("IsLessThan passed when value was greater");
        }

        #endregion

        #region [LessThanOrEqual]

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenIntValueIsLess()
        {
            NumAssert.IsLessThanOrEqual(5, 4);
        }

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenIntValueIsEqual()
        {
            NumAssert.IsLessThanOrEqual(5, 5);
        }

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenFloatValueIsLess()
        {
            NumAssert.IsLessThanOrEqual(5.00001f, 5.0f);
        }

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenFloatValueIsEqual()
        {
            NumAssert.IsLessThanOrEqual(5.00001f, 5.00001f);
        }

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenDoubleValueIsLess()
        {
            NumAssert.IsLessThanOrEqual(5.0023d, 5.0022d);
        }

        [TestMethod]
        public void NumAssert_LessThanOrEqual_ReturnsTrueWhenDoubleValueIsEqual()
        {
            NumAssert.IsLessThanOrEqual(5.0023d, 5.0023d);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_LessThanOrEqual_ThrowsWhenDoubleValueIsGreaterThan()
        {
            NumAssert.IsLessThanOrEqual(5.0023d, 5.0123d);
            Assert.Fail("LessThanOrEqual passed when value was greater");
        }

        #endregion

        #region [GreaterThan]

        [TestMethod]
        public void NumAssert_GreaterThan_ReturnsTrueWhenIntValueIsGreater()
        {
            NumAssert.IsGreaterThan(4, 5);
        }

        [TestMethod]
        public void NumAssert_GreaterThan_ReturnsTrueWhenFloatValueIsGreater()
        {
            NumAssert.IsGreaterThan(5.0f, 5.00001f);
        }

        [TestMethod]
        public void NumAssert_GreaterThan_ReturnsTrueWhenDoubleValueIsGreater()
        {
            NumAssert.IsGreaterThan(5.0022d, 5.0023d);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_GreaterThan_ThrowsWhenDoubleValueIsEqualTo()
        {
            NumAssert.IsGreaterThan(5.0023d, 5.0023d);
            Assert.Fail("IsLessThan passed when values were equal");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_GreaterThan_ThrowsWhenDoubleValueIsLessThan()
        {
            NumAssert.IsGreaterThan(5.0123d, 5.0023d);
            Assert.Fail("IsLessThan passed when value was less");
        }

        #endregion

        #region [GreaterThanOrEqual]

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenIntValueIsLess()
        {
            NumAssert.IsGreaterThanOrEqual(4, 5);
        }

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenIntValueIsEqual()
        {
            NumAssert.IsGreaterThanOrEqual(5, 5);
        }

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenFloatValueIsLess()
        {
            NumAssert.IsGreaterThanOrEqual(5.0f, 5.00001f);
        }

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenFloatValueIsEqual()
        {
            NumAssert.IsGreaterThanOrEqual(5.00001f, 5.00001f);
        }

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenDoubleValueIsLess()
        {
            NumAssert.IsGreaterThanOrEqual(5.0022d, 5.0023d);
        }

        [TestMethod]
        public void NumAssert_GreaterThanOrEqual_ReturnsTrueWhenDoubleValueIsEqual()
        {
            NumAssert.IsGreaterThanOrEqual(5.0023d, 5.0023d);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void NumAssert_GreaterThanOrEqual_ThrowsWhenDoubleValueIsLessThan()
        {
            NumAssert.IsGreaterThanOrEqual(5.0123d, 5.0023d);
            Assert.Fail("LessThanOrEqual passed when value was greater");
        }

        #endregion
    }
}
