using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionIncrementing
{
    class Program
    {
        static void Main(string[] args)
        {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

                DateTime buildDate = new DateTime(2010, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);

                string displayableVersion = $"{version} ({buildDate})";
                Console.WriteLine(displayableVersion);
                Console.ReadLine();
        }
    }
}
