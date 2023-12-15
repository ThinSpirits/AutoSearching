using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;

namespace AutoSearching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;

                var totalSearchesAllowed = (150/5); //30 change later to gather from writeline as some searches may have been completed
                var searchesAllowedPerGroup =  3;   //all change as this may change in the future
                var groupAmount = (totalSearchesAllowed/searchesAllowedPerGroup); //10
                var currentGroup = 0;

                var waitTime = GetWaitTime();
                var groupWaitTime = GetWaitTime("group");

                var allSearchTerms = GetTodaysSearches(totalSearchesAllowed);


                while (currentGroup > groupAmount)
                {
                    
                    //TODO: assign currentSearchTerm to next search term in index

                    var currentSearchTerm = new List<string>();
                    
                    for (int currentSearchesInGroup = 0; currentSearchesInGroup < searchesAllowedPerGroup; currentSearchesInGroup++)
                    {
                        //TODO: open a browser to next search term in current group
                        psi.FileName = currentSearchTerm[currentSearchesInGroup];

                        //sets process start to shell and sets site from target
                    

                        //opens browser
                        Process.Start(psi);
                        currentSearchesInGroup++;

                        //TODO: set next search term

                        Thread.Sleep(groupWaitTime);


                    }
                    currentGroup++;
                    
                    Thread.Sleep(waitTime);

                    //TODO: repeat until all groups have been searched

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        private static List<string> GetTodaysSearches(int totalSearchesAllowed)
        {
            
            //this is only a test to return something
            return new List<string> { "one", "two", "three" };


            //TODO: use total search number to fill list with different searches according to total search number

            /*
            These were used initially, may remove once searches are filled
              List.Add("http://www.bing.com");
              return searchTerms;
            */
        }


        static int GetWaitTime(string? waitParameter=null)
        {
            var waitTime = 0;
            if (waitParameter == "group")
                waitTime = 8000;//may need to gather from user

            else waitTime = 15000;//may need to gather from user

            return waitTime;
        }
        
    }
}