using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelpers.Tests
{
    [TestClass]
    public class ResourceLoaderTests
    {
        private static readonly string TEXT_RESOURCE = "Resources.textresource.txt";
        private static readonly string IMG_RESOURCE = "Resources.me.jpg";

        [TestMethod]
        public void ResourceLoader_GetResource_CanGetStringResource()
        {
            var expected = "This is a text file";
            var found = ResourceLoader.GetResourceString(TEXT_RESOURCE);
            Assert.AreEqual(expected, found);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ResourceLoader_GetResource_ThrowsExceptionWhenResourceNotFound()
        {
            var found = ResourceLoader.GetResourceString("Resources.NotARealThing.txt");
            Assert.Fail("ArgumentNullException was not thrown");
        }

        [TestMethod]
        public void ResourceLoader_GetResource_CanGetBinaryResource()
        {
            var found = ResourceLoader.GetResource(IMG_RESOURCE);
            Assert.IsNotNull(found);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ResourceLoader_GetResource_ThrowsExceptionWhenBinaryResourceNotFound()
        {
            var found = ResourceLoader.GetResource("Resources.NotARealThing.bin");
            Assert.Fail("NullReferenceException was not thrown");
        }
    }
}
