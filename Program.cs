using System;
using System.Media;
using System.Threading;

namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayAsciiLogo();
            WelcomeUser();
            ChatWithUser();
        }

        static void PlayVoiceGreeting()
        {
            {
                var myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\Amoge\source\repos\CybeSecurityAwarenessChatBot\bin\Debug\greeting.wav";     // WAV file in the project directory
                myPlayer.PlaySync();

            }
        }

        static void DisplayAsciiLogo()
        {
            Console.WriteLine(@"
    _____          _                           _____                    _                
   / ____|        | |                         / ____|                  | |               
  | |     __ _ ___| | ___ _ __ ___   ___ _ __| |  __ _ __ __ _ _ __ __| | ___ _ __ ___  
  | |    / _` / __| |/ _ \ '_ ` _ \ / _ \ '__| | |_ | '__/ _` | '__/ _` |/ _ \ '__/ _ \ 
  | |___| (_| \__ \ |  __/ | | | | |  __/ |  | |__| | | | (_| | | | (_| |  __/ | | (_) |
   \_____\__,_|___/_|\___|_| |_| |_|\___|_|   \_____|_|  \__,_|_|  \__,_|\___|_|  \___/ 
                                                                                         
            ");
        }

        static void WelcomeUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine().Trim();
            }

            Console.WriteLine($"\nWelcome, {name}! I'm here to help you stay safe online. Let's chat about cybersecurity.");
        }

        static void ChatWithUser()
        {
            string userInput;
            while (true)
            {
                Console.WriteLine("\nWhat would you like to ask me about? (Type 'exit' to leave)");
                userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine("Thank you for chatting! Stay safe!");
                    break;
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
                else
                {
                    RespondToUser(userInput);
                }
            }
        }

        static void RespondToUser(string input)
        {
            // Normalize input to a stripped version and check for known topics
            string normalizedInput = input.Replace("?", "").Trim(); // Remove question marks and trim empty spaces

            switch (normalizedInput)
            {
                case "how are you":
                    Console.WriteLine("I'm just a program, but I'm here to assist you!");
                    break;
                case "what's your purpose":
                    Console.WriteLine("My purpose is to help raise awareness about cybersecurity practices.");
                    break;
                case "what can i ask you about":
                    Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
                    break;
                case "password safety":
                    Console.WriteLine("Always use strong, unique passwords and consider using a password manager.");
                    break;
                case "phishing":
                    Console.WriteLine("Be cautious with email links and attachments. Always verify the sender.");
                    break;
                case "safe browsing":
                    Console.WriteLine("Use HTTPS websites, and be wary of public Wi-Fi networks.");
                    break;
                default:
                    // Display a message if the input does not match any case/ phrase
                    Console.WriteLine("I didn't quite understand that. Could you rephrase or ask about specific topics?");
                    break;
            }

            // A separator for better readability
            Console.WriteLine("..................");
        }
    }
}