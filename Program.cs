using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace creed_Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the ASCII logo
            DisplayLogo();

            // Play the voice greeting
            GreetingMessage();

            // Greet the user and ask for their name
            GreetUser();

            // Handle user input and provide responses
            UserInput();

        }

        static void DisplayLogo()
        {
            string logo = @"
   ______                   __                                           
  / ____/_______  ___  ____/ /                                           
 / /   / ___/ _ \/ _ \/ __  /                                            
/ /___/ /  /  __/  __/ /_/ /                                             
\____/_/_  \___/\___/\__,_/   _       __                _                
  / ____/_  __/ /_  ___  ____| |     / /___ ___________(_)___  __________
 / /   / / / / __ \/ _ \/ ___/ | /| / / __ `/ ___/ ___/ / __ \/ ___/ ___/
/ /___/ /_/ / /_/ /  __/ /   | |/ |/ / /_/ / /  / /  / / /_/ / /  (__  ) 
\____/\__, /_.___/\___/_/    |__/|__/\__,_/_/  /_/  /_/\____/_/  /____/  
    _/____/     __                                                       
   / __ )____  / /_                                                      
  / __  / __ \/ __/                                                      
 / /_/ / /_/ / /_                                                        
/_____/\____/\__/                                                                                                                           
            ";
            Console.WriteLine(logo);
        }

        static void GreetingMessage()
        {
            try
            {

                SoundPlayer player = new SoundPlayer("welcome.wav");
                //player.PlaySync();

            }

            catch (Exception ex)
            {

                Console.WriteLine("Error playing the greeting: " + ex.Message);

            }

        }

        static void GreetUser()
        {
            Console.WriteLine("What's your name? ");
            var userName = Console.ReadLine();
            TypingDelay($"\nHello, {userName}! Welcome to the Creed CyberWorrias Bot, where we keep you protected and informed about the online world.");
        }

        static void UserInput()
        {
            while (true)
            {
                Console.WriteLine("\nWhat would you like to know? Type your question from below:");
                Console.WriteLine("\"How are you?\"");
                Console.WriteLine("\"What is your purpose?\"");
                Console.WriteLine("\"What can I ask you?\"");
                Console.WriteLine("\"Password Safety\"");
                Console.WriteLine("\"Phishing\"");
                Console.WriteLine("\"Safe Browsing\"");
                Console.WriteLine("\"Help\"");
                Console.WriteLine("\"What is Two-Factor Authentication?\"");
                Console.WriteLine("\"How can I protect against malware?\"");
                Console.WriteLine("\"What is social engineering?\"");
                Console.WriteLine("\"How can I protect my data privacy?\"");
                Console.WriteLine("\"What are some general cybersecurity tips?\"");
                Console.WriteLine("\n");
                Console.WriteLine("Type 'exit' to quit.");

                string input = Console.ReadLine().Trim().ToLower();

                if (input == "exit")
                    break;

                switch (input)
                {
                    case "how are you?":
                        TypingDelay("I'm just a bot, but I'm here to help you stay safe online!");
                        WaitForUserInput();
                        break;

                    case "what is your purpose?":
                        TypingDelay("My purpose is to educate you about cybersecurity best practices.");
                        WaitForUserInput();
                        break;

                    case "what can i ask you?":
                        TypingDelay("You can ask me about password safety, phishing, safe browsing, and more.");
                        WaitForUserInput();
                        break;

                    case "password safety":
                        TypingDelay("Use strong, unique passwords and enable two-factor authentication.");
                        WaitForUserInput();
                        break;

                    case "phishing":
                        TypingDelay("Be cautious of suspicious emails and links. Always verify the sender's identity.");
                        WaitForUserInput();
                        break;

                    case "safe browsing":
                        TypingDelay("Use HTTPS, avoid public Wi-Fi for sensitive tasks, and keep your browser updated.");
                        WaitForUserInput();
                        break;

                    case "help":
                        TypingDelay("You can ask me questions related to cybersecurity, and I'll do my best to help!");
                        WaitForUserInput();
                        break;

                    case "what is two-factor authentication?":
                        TypingDelay("Two-factor authentication adds an extra layer of security to your accounts.");
                        WaitForUserInput();
                        break;

                    case "how can i protect against malware?":
                        TypingDelay("Keep your antivirus software updated and avoid downloading unknown files.");
                        WaitForUserInput();
                        break;

                    case "what is social engineering?":
                        TypingDelay("Be wary of unsolicited requests for personal information. Verify before sharing.");
                        WaitForUserInput();
                        break;

                    case "how can i protect my data privacy?":
                        TypingDelay("Limit the personal information you share online to protect your privacy.");
                        WaitForUserInput();
                        break;

                    case "what are some general cybersecurity tips?":
                        TypingDelay("Regularly update your software and be cautious of suspicious links.");
                        WaitForUserInput();
                        break;

                    default:
                        TypingDelay("I didn't quite understand that. Could you rephrase?");
                        break;
                }
            }
        }

        static void TypingDelay(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);//30ms delay
            }
            Console.WriteLine("\n");

        }


        static void WaitForUserInput()
        // Wait for the user to press a key before continuing
        {
            Console.WriteLine("Click any key to go back to the menu...");
            Console.ReadKey();


        }
    }
}
