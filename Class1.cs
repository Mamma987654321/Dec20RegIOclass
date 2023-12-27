using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Dec20RegIOclass
{
    internal class Class1
    {//fllng code will display all the classes of system namespace
        static void Main(string[] args)
        {
            Assembly assem = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\System.dll");
            foreach(Type oneClass in assem.GetTypes())
            {
                Console.WriteLine(oneClass);
            }
            Type tt = typeof(string);
            Console.WriteLine("Name{0}" ,tt.Name);
            Console.WriteLine(" Namespace {0} ", tt.Namespace);
            Console.WriteLine("Base class {0} ", tt.BaseType);
            Console.ReadLine();
        }
    }
}
