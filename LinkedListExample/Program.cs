using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLL binaryTree = new MyLL();
            char userInput;
            while(true)
            {
                Console.WriteLine("Would you like to add or search?  Press 1 or 2.");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if(userInput.ToString() == "1")
                {
                    try
                    {
                        binaryTree.Add();
                    }
                    catch
                    {

                    }
                }
                if(userInput.ToString() == "2")
                {
                    try
                    {
                        Console.WriteLine("Enter a number you'd like to search for.");
                        binaryTree.Search(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch
                    {

                    }
                }

            }
            ////Dictionary<keyType, valueType>
            //Dictionary<string, bool> foo = new Dictionary<string, bool>();
            //foo.Add("name", true);
            ////reference item in dictionary
            //bool fee = foo["name"];
            //foreach(KeyValuePair<string, bool> entry in foo)
            //{
            //    Console.WriteLine(entry.Key, entry.Value);
            //}
        }
    }
}
