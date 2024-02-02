using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture.Helpers
{
    public static class ConsoleLogger
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"[Log]: {message}");
            Console.ResetColor();
        }
    }
}
