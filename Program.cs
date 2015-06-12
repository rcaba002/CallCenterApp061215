using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Core;

namespace CallCenterApp
{
    public class Program
    {
        private static string _userInput;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("                  Welcome                 ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("C - Create An Issue      F - Find An Issue");
                Console.WriteLine("D - Delete An Issue      Q - Quit\n");

                var readLine = Console.ReadLine();
                if (readLine != null) _userInput = readLine.Trim().ToUpper();

                switch (_userInput)
                {
                    case "C": Create();
                        break;
                    case "F": Find();
                        break;
                    case "D": Delete();
                        break;
                    case "Q":
                        return;
                }
            }
        }

        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("Add Client Page");
            Console.WriteLine("---------------");
            Console.Write("Client Name: ");
            var client = Console.ReadLine().ToUpper();
            Console.Write("Issue Title: ");
            var title = Console.ReadLine().ToUpper();

            Actions.CreateNew(client, title);

            Console.Clear();
            Console.WriteLine("Add Issue Page");
            Console.WriteLine("---------------");
            Console.WriteLine("New Issue Added");
            Console.WriteLine("{0} - Issue Id # {1}", client, Issue.IssueId);
            Console.WriteLine("{0} - {1}", Issue.Date, title);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }

        public static void Find()
        {
            var userInput = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Find Issue Page");
                Console.WriteLine("----------------");
                Console.WriteLine("N - By Name");
                Console.WriteLine("M - Return To Main Menu\n");

                var readLine = Console.ReadLine();
                if (readLine != null) userInput = readLine.Trim().ToUpper();

                if (userInput == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Find Issue Page");
                    Console.WriteLine("----------------");
                    Console.Write("Name: ");
                    var readline = Console.ReadLine();
                    if (readline != null) userInput = readline.ToUpper();

                    Console.Clear();
                    Console.WriteLine("Find Issue Page");
                    Console.WriteLine("-----------------");

                    Console.WriteLine(Actions.FindNew(userInput));

                    Console.Write("\nPress any key...");
                    Console.ReadKey();
                    break;
                }

                if (userInput == "M")
                {
                    return;
                }
            }
        }

        public static void Delete()
        {
            var userInput = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Delete Issue Page");
                Console.WriteLine("----------------");
                Console.WriteLine("N - By Name");
                Console.WriteLine("M - Return To Main Menu\n");

                var readLine = Console.ReadLine();
                if (readLine != null) userInput = readLine.Trim().ToUpper();

                if (userInput == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Delete Issue Page");
                    Console.WriteLine("----------------");
                    Console.Write("Name: ");
                    var readline = Console.ReadLine();
                    if (readline != null) userInput = readline.ToUpper();

                    Actions.DeleteNew(userInput);

                    Console.Clear();
                    Console.WriteLine("Delete Issue Page");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Issue Deleted");
                    Console.Write("\nPress any key...");
                    Console.ReadKey();
                    break;
                }

                if (userInput == "M")
                {
                    return;
                }
            }
        }
    }
}
