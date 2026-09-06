using System;
using System.Threading;

namespace Recording
{
    internal class ChatBot
    {
        public void StartChat()
        {
            // Ask for the user's name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            string? name = Console.ReadLine();

            // Validate the user's name
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty.");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter your name: ");
                Console.ResetColor();

                name = Console.ReadLine();
            }

            // Welcome the user
            Console.ForegroundColor = ConsoleColor.Green;
            TypeText($"\nWelcome, {name}!");
            Console.WriteLine();
            TypeText("I am your Cybersecurity Awareness Chatbot.");
            Console.WriteLine();
            TypeText("I am here to help you learn how to stay safe online.");
            Console.WriteLine();
            Console.ResetColor();

            DisplayHelp();

            bool continueChatting = true;

            // Main chatbot loop
            while (continueChatting)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{name}: ");
                Console.ResetColor();

                string? question = Console.ReadLine();

                // Validate empty input
                if (string.IsNullOrWhiteSpace(question))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didn't enter a question. Please try again.");
                    Console.ResetColor();
                    continue;
                }

                question = question.Trim().ToLowerInvariant();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Bot: ");
                Console.ResetColor();

                // Respond to the user's question
                if (question == "hello" || question == "hi" ||
                    question.StartsWith("hello ") || question.StartsWith("hi "))
                {
                    TypeText($"Hello, {name}! It's nice to meet you. How can I help you stay safe online?");
                }
                else if (question.Contains("how are you"))
                {
                    TypeText("I'm doing great, thank you for asking! I'm always ready to help you learn about cybersecurity.");
                }
                else if (question.Contains("purpose") || question.Contains("what do you do"))
                {
                    TypeText("My purpose is to create awareness about cybersecurity and teach you how to protect yourself from common online threats.");
                }
                else if (question.Contains("what can i ask") ||
                         question.Contains("help") ||
                         question.Contains("topics"))
                {
                    DisplayHelp();
                }
                else if (question.Contains("password"))
                {
                    TypeText("Password Safety: Use a long, strong and unique password for every account.");
                    Console.WriteLine();
                    TypeText("A strong password should include uppercase letters, lowercase letters, numbers and symbols.");
                    Console.WriteLine();
                    TypeText("Never share your password with anyone, and avoid reusing the same password on different accounts.");
                }
                else if (question.Contains("phishing") ||
                         question.Contains("scam email") ||
                         question.Contains("suspicious email"))
                {
                    TypeText("Phishing is a scam where criminals try to trick you into giving away personal or sensitive information.");
                    Console.WriteLine();
                    TypeText("Be careful of suspicious emails, messages and links. Always check the sender and do not share passwords or sensitive information.");
                }
                else if (question.Contains("safe browsing") ||
                         question.Contains("browsing") ||
                         question.Contains("website") ||
                         question.Contains("suspicious link"))
                {
                    TypeText("Safe Browsing: Only visit websites you trust and avoid clicking suspicious links or pop-ups.");
                    Console.WriteLine();
                    TypeText("Check that the website address is correct and be cautious before entering personal information online.");
                }
                else if (question.Contains("cybersecurity") ||
                         question.Contains("online safety") ||
                         question.Contains("stay safe"))
                {
                    TypeText("To stay safe online, use strong passwords, keep your software updated, avoid suspicious links and never share sensitive information with untrusted people.");
                }
                else
                {
                    TypeText($"Sorry, {name}, I didn't quite understand that.");
                    Console.WriteLine();
                    TypeText("You can type 'help' to see the cybersecurity topics I can assist you with.");
                }

                Console.WriteLine("\n");

                // Ask whether the user wants to continue
                bool validResponse = false;

                while (!validResponse)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Enter 1 to ask another question or 0 to exit: ");
                    Console.ResetColor();

                    string? responseInput = Console.ReadLine();

                    if (responseInput == "1")
                    {
                        validResponse = true;
                    }
                    else if (responseInput == "0")
                    {
                        continueChatting = false;
                        validResponse = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter only 1 to continue or 0 to exit.");
                        Console.ResetColor();
                    }
                }
            }

            // Goodbye message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            TypeText($"Thank you for using the Cybersecurity Awareness Chatbot, {name}!");
            Console.WriteLine();
            TypeText("Remember: Stay alert, think before you click, and stay safe online!");
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.ResetColor();
        }

        // Display the available chatbot topics
        private void DisplayHelp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("                 WHAT YOU CAN ASK ME");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing Scams");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. General Cybersecurity");
            Console.WriteLine();
            Console.WriteLine("Example: How do I create a strong password?");
            Console.WriteLine("=======================================================");

            Console.ResetColor();
        }

        // Creates a typing effect for chatbot responses
        private void TypeText(string message)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(20);
            }
        }
    }
}
