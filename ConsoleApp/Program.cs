using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp;
using sand;
using static System.Console;

namespace sand
{
    class Program
    {
        public static void Main()
        {
            var bindFlags = BindingFlags.Instance | BindingFlags.Static |
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.FlattenHierarchy;
 
            var members = typeof( ISwiftTranslate ).GetMembers( bindFlags );

            foreach (var m in members)
                Console.WriteLine(m.Name);
        }
    }
}
