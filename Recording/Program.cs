using System;
using System.Media;

namespace Recording
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Student\OneDrive - ADvTECH Ltd\Attachments\Bope_recording.wav");

            Logo logo = new Logo();

            logo.Display();

            player.Play();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Voice played successfully!");
            Console.ResetColor();

            //Start the chatbot
            ChatBot bot = new ChatBot();
            bot.StartChat();

            Console.ReadKey();
        }
    }
}