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

                //var psi = new ProcessStartInfo();
                //psi.UseShellExecute = true;
                Console.WriteLine("How many points are left to be gained from searching?");
                int totalPointsAllowed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many points are gained per search");
                int pointsLeftToGain = Convert.ToInt32(Console.ReadLine());
                var totalSearchesAllowed = (totalPointsAllowed / pointsLeftToGain);
                Console.WriteLine("How many searches are allowed at a time?");
                var searchesAllowedPerGroup = Convert.ToInt32(Console.ReadLine());   
                var groupAmount = (totalSearchesAllowed / searchesAllowedPerGroup); 

                var waitTime = GetWaitTime();
                var groupWaitTime = GetWaitTime("group");

                var todaysSearches = GetTodaysSearches(totalSearchesAllowed);


                for (int i = 0; i < totalSearchesAllowed; i++)
                {
                    //psi.FileName = todaysSearches[i];
                    //Process.Start(psi);
                    //Console.WriteLine($"Current Search: {psi.FileName}");

                    var searchTerm = todaysSearches[i];

                    Console.WriteLine($"Current search: {searchTerm}");
                    if ((i + 1) % searchesAllowedPerGroup == 0)
                    {
                        Console.WriteLine($"Waiting: {waitTime}");
                        Thread.Sleep(waitTime);
                    }
                    else
                    {
                        Console.WriteLine($"Waiting: {groupWaitTime}");
                        Thread.Sleep(groupWaitTime);
                    }
                }



            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        public static List<string> GetTodaysSearches(int totalSearchesAllowed)
        {

            //TODO: put actual search terms into the list
            return new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                        "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
                        "twenty", "twentyone", "twentytwo", "twentythree", "twentyfour", "twentyfive", "twentysix", "twentyseven",
                        "twentyeight", "twentynine","thirty"};

        }


        static int GetWaitTime(string? waitParameter = null)
        {
            var waitTime = 0;
            if (waitParameter == "group")
                waitTime = 8000;

            else waitTime = 150000;

            return waitTime;
        }

    }
}