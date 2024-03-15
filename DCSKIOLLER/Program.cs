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
                Console.WriteLine($"DCS was killed. Exiting now in 5 seconds...");
                Thread.Sleep(5000);
                Environment.Exit(503365);
            }
            else
            {
                Console.WriteLine($"DCS not found. Exiting in 5 seconds...");
                Thread.Sleep(5000);
                Environment.Exit(101);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error when closing DCS: {ex.Message}. Exeting in 5 seconds");
            Thread.Sleep(5000);
            Environment.Exit(202);
        }
    }
}




