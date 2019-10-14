using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TicketSearch : TicketBase
    {
        public void TSearchOption()
        {
            Console.WriteLine("Type 1: Priority Search");
            Console.WriteLine("Type 2: Status Search");
            Console.WriteLine("Type 3: Submitter Search");
            Console.WriteLine("Type 4: All Search");
            Console.WriteLine("Enter anything else to quit" );
            var userEntry = Console.ReadLine().ParseInt();
           
            switch(userEntry)
            {
                case 1:

                    Console.WriteLine("Enter Priority");
                    string prioritySearch = Console.ReadLine();
                    displayTicketPriority(prioritySearch);
                    break;
                case 2:
                    Console.WriteLine("Enter Status");
                    string statusSearch = Console.ReadLine();
                    displayTicketStatus(statusSearch);
                    break;
                case 3:
                    Console.WriteLine("Enter Submitter");
                    string submitterSearch = Console.ReadLine();
                    displayTicketSubmitter(submitterSearch);
                    break;
                case 4:
                    allSearch();
                    break;
                default:
                    Logger.Info("Closing Program...");
                    sw.Close();
                    break;
            }
        }

        private void allSearch()
        {
            var searchResults = new List<>();
            searchResults.Concat<>;
        }

        void displayTicketSubmitter(string submitterSearch)
        {
            var searchResults = new List<>();
            searchResults.Where(i => i.searchResults.Contains(submitterSearch));
        }

        void displayTicketStatus(string statusSearch)
        {
            var searchResults = new List<>();
            searchResults.Where(i => i.searchResults.Contains(statusSearch));
        }

        void displayTicketPriority(string prioritySearch)
        {
            var searchResults = new List<>();
            searchResults.Where(i => i.searchResults.Contains(prioritySearch));
        }
    }
}
