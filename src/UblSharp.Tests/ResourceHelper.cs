using System.IO;
using System.Reflection;

namespace UblSharp.Tests
{
    public static class ResourceHelper
    {
        public static Stream GetResource(string name)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(ResourceHelper).Namespace + "." + name);
        }
    }
}