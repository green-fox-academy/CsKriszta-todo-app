using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODO_Application
{
    class Program
    {
        public static void PrintUsage(string[] args)
        {
            string usage = "Command line todo application \n============================= \n \n \n Command line arguments: \n -l  Lists all the tasks \n -a  Adds a new task \n -r  Removes an task \n -c  Completes an task";
            if (args.Length == 0)
            {
                Console.WriteLine(usage); 
            } 
        }

        public static List<string> ReadList()
        {
            StreamReader TDList = new StreamReader("TextList.txt");
            string line = "";
            var list = new List<string>();
            while (line != null)
            {
                line = TDList.ReadLine();
                list.Add(line);
            }
            TDList.Close();
            return list;           
        }

        public static void PrintList(List<string> inputList)
        {
            for(int i = 0; i < inputList.Count; i++)
            {
                Console.WriteLine(i.ToString() + inputList[i]);
            }
        }
        static void Main(string[] args)
        {
            PrintUsage(args);
            Console.ReadLine();

            if (args ==

        }
    }
}
