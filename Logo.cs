using System;

namespace Recording
{
    internal class Logo
    {
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║        ██████╗  ██████╗ ██████╗ ███████╗                    ║");
            Console.WriteLine("║        ██╔══██╗██╔═══██╗██╔══██╗██╔════╝                    ║");
            Console.WriteLine("║        ██████╔╝██║   ██║██████╔╝█████╗                      ║");
            Console.WriteLine("║        ██╔══██╗██║   ██║██╔═══╝ ██╔══╝                      ║");
            Console.WriteLine("║        ██████╔╝╚██████╔╝██║     ███████╗                    ║");
            Console.WriteLine("║        ╚═════╝  ╚═════╝ ╚═╝     ╚══════╝                    ║");
            Console.WriteLine("║                                                              ║");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║          CYBERSECURITY AWARENESS CHATBOT                    ║");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}
