using System.Diagnostics;

namespace AutoSearching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TODO: set number of searches
                //TODO: obtain different search targets
                //TODO: set group number
                //TODO: for each group, run number of searches
                //TODO: set wait time between searches
                //TODO: set wait time during group
                
                
                //set site
                var target = "http://www.bing.com";
                
                //sets process start to shell and sets site from target
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;

                psi.FileName = target;

                //opens browser
                Process.Start(psi);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
        
    }
}