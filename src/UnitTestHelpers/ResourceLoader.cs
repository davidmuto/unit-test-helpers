using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelpers
{
    /// <summary>
    /// A class that loads embedded resources from the calling assembly
    /// </summary>
    public class ResourceLoader
    {
        /// <summary>
        /// Reads an embedded resource and returns the raw bytes of that resource
        /// </summary>
        /// <param name="name">The name of the resource</param>
        /// <remarks>Will prefix the supplied name with the assembly name</remarks>
        public static byte[] GetResource(string name)
        {
            var asm = Assembly.GetCallingAssembly();
            var res = string.Format("{0}.{1}", asm.GetName().Name, name);

            using (var stream = asm.GetManifestResourceStream(res))
            {
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        /// <summary>
        /// Reads an embedded resource as a string a returns the result
        /// </summary>
        /// <param name="name">The name of the resource</param>
        /// <remarks>Will prefix the supplied name with the assembly name</remarks>
        public static string GetResourceString(string name)
        {
            var asm = Assembly.GetCallingAssembly();
            var res = string.Format("{0}.{1}", asm.GetName().Name, name);

            using (var stream = asm.GetManifestResourceStream(res))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
