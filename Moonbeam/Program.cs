using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Moonbeam
{
    class Program
    {
        static void Main(string[] args)
        {
            MBM.LoadDictionary(File.ReadAllLines("dic.txt"));
            foreach (var path in args)
            {
                switch (Path.GetExtension(path).ToLower())
                {
                    case ".mbm":
                        File.WriteAllText(path + ".xml", MBM.FromByteArray(File.ReadAllBytes(path)).ToXElement().ToString());
                        break;
                    case ".xml":
                        File.WriteAllBytes(path + ".mbm", MBM.FromXElement(XElement.Load(path)).ToByteArray());
                        break;
                }
            }
        }

        // Enter a root directory to test all MBMs in the directory
        static void UnitTest(string rootDirectory)
        {
            foreach (var path in Directory.GetFiles(rootDirectory, "*.mbm", SearchOption.AllDirectories))
            {
                Console.WriteLine(path);
                var original = File.ReadAllBytes(path);
                var modified = MBM.ToByteArray(MBM.FromXElement(MBM.ToXElement(MBM.FromByteArray(original))));
                if (!original.SequenceEqual(modified)) throw new Exception("Byte sequences are not the same");

                System.Diagnostics.Debug.WriteLine(MBM.FromByteArray(original).ToXElement());
            }
        }
    }
}
