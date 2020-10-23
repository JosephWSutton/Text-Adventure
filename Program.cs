using System;

namespace TheVagabondsDirectiveToTheUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int vagaLevel = 0;

            Console.Write("Wake up! What are you doing sleeping at a time like this?\n" +
                "You don't look so good. Did you hit your head old chap?\n Do you at least " +
                "remember your name?\nENTER YOUR NAME: ");

            playerName = (Console.ReadLine());//Enters Player Name

            Console.WriteLine("Ahh, well at least you rembember that!");

            Console.WriteLine("Do you happen to recall that we are currently running\n from " +
                "the Blorgon army and they are less then two parsnics behind us????\n " +
                "Well by the look on your face I daresay not.\nPRESS ENTER TO CONTINUE");

            Console.ReadLine();//Makes Enter Key Continue Script

            Console.WriteLine($"Well here is the gist of it {playerName}, \n" +
                $"The Blorgon empire does not look favorably on vagabonds such as ourselves.\n" +
                $"Their distaste reached it's pinnacle when you decided the Blorgon princess was\n" +
                $"in need of some... extra-curricular romping, which YOU SHOULD KNOW is strongly reccomended against in chapter\n" +
                $"four, section eleven, paragraph six of the directive! Oh lord you probably don't even remember that. Do you happen to remember???\n" +
                $"PRESS y FOR YES, n FOR NO\n\n ");// Game Instructions

            string key = Console.ReadKey().Key.ToString();
            
            if (key.ToLower() == "y") //Directive Explanation
                Console.WriteLine("\nOh great, the Blorgon army is not scary even though they will disembowel us\n" +
                    " on sight, and I have plenty of time to explain the most important tool we have to you.\n" +
                    "The Vagabonds Directive is how lowly wanderers such as ourselves navigate our way through this\n " +
                    "complicated world. Throughout our journey I will read some of it to you to help make decisions.\n" +
                    "PRESS ENTER TO CONTINUE");

            if (key.ToLower() == "n")
                Console.WriteLine($"\nWell I don't believe you trashbag, im sorry, {playerName}, and I will explain anyway/n" +
                    "The Vagabonds Directive is how lowly wanderers such as ourselves navigate our way through this\n " +
                    "complicated world. Throughout our journey I will read some of it to you to help make decisions.\n" +
                    "PRESS ENTER TO CONTINUE");
            else
            {
                Console.WriteLine("\nDid you forget how to use a keyboard too, you bumbling lunatic??\n" +
                    "press y for yes or n for no!");
              
            }

        }
    }
}
