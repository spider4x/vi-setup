using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VICore;

namespace VirtualIdentity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(new IdentityGenerator().GenerateJson());
            Console.ReadLine();
        }
    }
}
