using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_Application
{
    class Program
    {
        public void PrintUsage(params string[] args)
        {
            string usage = "Command line todo application \n ============================= \n \n \n Command line arguments \n -a  Adds a new task \n -r  Removes an task \n -c  Completes an task";
            if (args.Length == 0)
            {
                Console.WriteLine(usage); 
            } 
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

        }
    }
}
