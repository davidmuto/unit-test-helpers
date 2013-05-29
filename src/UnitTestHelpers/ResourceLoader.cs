using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelpers
{
    public class ResourceLoader
    {
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
