using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSwithAbraham
{
    public class Program
    {
        static Random random = new Random();
        static void Shuffle<T>(T[] array)
        
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        static void Main(string[] args)
        {
            string option = "";
            string cpuAnswer = "";
            string[] cpu = { "Rock", "Paper", "Scissors" };
            string playMore = "";
            string win = "You win...";

            string lose = "Haha! I win!";
            string draw = "Draw!";
            int playerScore = 0;
            int cpuScore = 0;
            string name;
            int w = -1;
            int d = -1;
            int l = -1;


            Console.WriteLine("Welcome to the Ultimate Rock, Paper, & Scissors Game!");
            Console.ReadLine();
            Console.WriteLine("Today you'll be facing off against myself, Abraham, in a game of mental fortitude.");
            Console.ReadLine();
            Console.WriteLine("We'll be playing in a first to 5!");
            Console.ReadLine();

            Console.WriteLine("First up though, what's your name?");
            name = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + name + ". Just remember, no one likes a sore loser!");
            Console.ReadLine();

            Console.WriteLine("Let's begin!");
            Console.ReadLine();

            string[] cpuWin = {
            "I read you like a book, " + name + ".",
            "I'm beating your ass," + name + "!",
            name + ". Git gud.",
            "Do you want to start betting " + name + "? Cause this would be EASY MONEY!",
            name + "... I wasn't even paying attention and I still won...",
            "I. Am. God.",
            "This isn't luck you know " + name + ", this is all skill baby!",
            "Come now " + name + ", do you think you have a chance of beating me at all?",
            "There is no universe where you win.",
            "Can I offer you an egg in this trying time?",
            "Nobody's perfect.",
            "I wish you knew when to quit",
            "You know how to play, don't you, " + name + "?",
            "I'm the king of the world!",
            "You've got to ask yourself one question... 'Do I feel lucky?'... Well, do ya punk?",
            "Show me the money!",
            "There's not crying in RPS!",
            "Why so serious?"};
            string[] cpuLose = {
            "I don't understand. What's going on?",
            "You know what, " + name + ", I don't have time for this.",
            "You may take this win, " + name + ", but you'll never take my freedom!",
            "I could win everytime if I played as lame as you.",
            "Playing against you is just one big ass blast!",
            name + ", if you let me win from now, that'll be the end of it. I will not look for you, I will not pursue you. But if you don't let me win, I will look for you, I will find you, and I will kill you.",
            "What are you doing " + name + "? This is just a friendly game.",
            "Uh, our friendship is in danger " + name + ".",
            "I'm living in a world of darkness.",
            "My name is Abraham Maximus Decimus! I will have my vengeance, in this life or the next!",
            name + ", you make me want to be a better man",
            "...I'm mad as hell, " + name + ", and I'm not going to take this anymore!"};
            string[] cpuDraw = {
            "Seems I've met my match!",
            "But I've got data on you now, " + name + ", don't let me get in your head!",
            "Go again!",
            "You got lucky, " + name + "but I'll win next time!",
            "Alright, we're pretty equal right now.",
            "Copycat!",
            "Are we the same person?",
            "I am you and you are me!",
            "As if!",
            "I don't want to draw. I want to win.",
            "Just keep playing."};

            bool keepPlaying = false;
            bool incorrectInput = false;

            Shuffle(cpuWin);
            Shuffle(cpuDraw);
            Shuffle(cpuLose);

            do
            {
                int randomNumber = random.Next(0, 3);

                Console.WriteLine("Choose between Rock, Paper or Scissors:");
                option = Console.ReadLine();
                string convertToLower = option.ToLower();

                cpuAnswer = cpu[0];

                Console.WriteLine(cpuAnswer);
                Console.ReadLine();

                if (d > 10)
                {
                    d = -1;
                }

                switch (convertToLower)
                {
                    case "rock":
                    case "r":
                        if (cpuAnswer == "Rock")
                        {
                            Console.WriteLine(draw);
                            Console.WriteLine(cpuDraw[d + 1]);
                            Console.ReadLine();
                            d++;
                        }
                        else if (cpuAnswer == "Paper")
                        {
                            Console.WriteLine(lose);
                            Console.WriteLine(cpuWin[w + 1]);
                            Console.ReadLine();
                            cpuScore++;
                            w++;
                        }
                        else if (cpuAnswer == "Scissors")
                        {
                            Console.WriteLine(win);
                            Console.WriteLine(cpuLose[l + 1]);
                            Console.ReadLine();
                            playerScore++;
                            l++;

                        }
                        break;
                    case "paper":
                    case "p":
                        if (cpuAnswer == "Paper")
                        {
                            Console.WriteLine(draw);
                            Console.WriteLine(cpuDraw[d + 1]);
                            Console.ReadLine();
                            d++;
                        }
                        else if (cpuAnswer == "Scissors")
                        {
                            Console.WriteLine(lose);
                            Console.WriteLine(cpuWin[w + 1]);
                            Console.ReadLine();
                            cpuScore++;
                            w++;
                        }
                        else if (cpuAnswer == "Rock")
                        {
                            Console.WriteLine(win);
                            Console.WriteLine(cpuLose[l + 1]);
                            Console.ReadLine();
                            playerScore++;
                            l++;
                        }
                        break;
                    case "scissors":
                    case "s":
                        if (cpuAnswer == "Scissors")
                        {
                            Console.WriteLine(draw);
                            Console.WriteLine(cpuDraw[d + 1]);
                            Console.ReadLine();
                            d++;
                        }
                        else if (cpuAnswer == "Rock")
                        {
                            Console.WriteLine(lose);
                            Console.WriteLine(cpuWin[w + 1]);
                            Console.ReadLine();
                            cpuScore++;
                            w++;
                        }
                        else if (cpuAnswer == "Paper")
                        {
                            Console.WriteLine(win);
                            Console.WriteLine(cpuLose[l + 1]);
                            Console.ReadLine();
                            playerScore++;
                            l++;
                        }
                        break;
                    default:
                        Console.WriteLine("{0} isn't an option so... You lose!", option);
                        Console.ReadLine();
                        cpuScore++;
                        break;
                }

                Console.WriteLine(name + "'s Score: {0}", playerScore);
                Console.WriteLine("Abraham's Score: {0}", cpuScore);
                Console.ReadLine();

                if (playerScore < 5 && cpuScore < 5)
                {
                    keepPlaying = true;
                }
                else if (playerScore == 5)
                {
                    Console.WriteLine("Alright, you win. Good games, {0}!", name);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (cpuScore == 5)
                {
                    Console.WriteLine("That's 5 wins for me, I win..");
                    Console.ReadLine();
                    Console.WriteLine("You come at the king, " + name + ", you best not miss.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                do
                {
                    Console.WriteLine("Play again? (Y/N)");
                    playMore = Console.ReadLine();
                    string playToLower = playMore.ToLower();

                    if (playToLower == "y")
                    {
                        keepPlaying = true;
                        incorrectInput = false;
                    }
                    else if (playToLower == "n")
                    {
                        Console.WriteLine("Good games, {0}!", name);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine(name + " that's not a valid option.");
                        Console.ReadLine();
                        incorrectInput = true;
                    }

                } while (incorrectInput);

            } while (keepPlaying);

        }

    }

}
