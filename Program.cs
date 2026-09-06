using System;
using System.Media;

namespace Recording
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            // Clear the console
            Console.Clear();

            // Display the cybersecurity logo
            Logo logo = new Logo();
            logo.Display();

            // Play the voice greeting
            SoundPlayer player = new SoundPlayer(
                @"C:\Users\Student\OneDrive - ADvTECH Ltd\Attachments\Bope_recording.wav");

            player.PlaySync();

            // Clear the screen after the voice greeting
            Console.Clear();

            // Start the chatbot
            ChatBot chatbot = new ChatBot();
            chatbot.StartChat();
        }
    }
}
