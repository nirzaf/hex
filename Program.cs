using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace hex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"0x{int.Parse(args[0]):X}");

            }
            catch
            {
                Console.WriteLine("Invalid argument");
            }
        }
    }
}
