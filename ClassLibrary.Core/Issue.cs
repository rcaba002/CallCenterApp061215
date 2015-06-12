using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Core
{
    public class Issue
    {
        public static string ClientName { get; set; }
        public static int IssueId { get; set; }
        public static string Title { get; set; }
        public static DateTime Date { get; set; }

        public Issue(string client, int id, string title, DateTime date)
        {
            ClientName = client;
            IssueId = id;
            Title = title;
            Date = date;
        }

        public override string ToString()
        {
            return string.Format("{0} - Issue Id # {1} \n {2} - {3}", ClientName, IssueId, IssueId, Title);
        }
    }
}
