using System;
using System.Diagnostics;

class Program
{

    static void Main()
    {   
        KillProcess();
    }

    static void KillProcess()
    {
        try
        {
            // Search for process
            Process[] process = Process.GetProcessesByName("DCS");

            if (process.Length > 0)
            {
                // Exit process
                process[0].Kill();
                Console.WriteLine($"DCS was killed. Exiting now...");
                Environment.Exit(2500);
            }
            else
            {
                Console.WriteLine($"DCS not found.");
                Environment.Exit(2500);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error when closing DCS: {ex.Message}");
            Environment.Exit(2500);
        }
    }
}



