using System;
using murrayju.ProcessExtensions;

namespace StartPowershell
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("args is null");
            }
            else
            {
                ProcessExtensions.StartProcessAsCurrentUser(args[0]);
            }
            
        }
    }
}
