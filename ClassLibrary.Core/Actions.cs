using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core
{
    public class Actions
    {
        public static List<Issue> Database = new List<Issue>();
        static readonly DateTime Date = DateTime.Now;
        static readonly Random Rnd = new Random();
        private readonly static int Id = Rnd.Next(1, 1000000);


        public static void CreateNew(string client, string title)
        {
            var issue = new Issue(client, Id, title, Date);
            Database.Add(issue);
        }

        public static string FindNew(string userInput)
        {
            var item = "";

            foreach (var x in Database)
            {
                if (Issue.ClientName == userInput)
                {
                    item = x.ToString();
                }
            }

            return item;
        }

        public static void DeleteNew(string userInput)
        {
            var itemsToRemove = Actions.Database.Where(item => Issue.ClientName == userInput).ToList();

            foreach (var item in itemsToRemove)
            {
                Database.Remove(item);
            }
        }
    }
}
