using System;


namespace passwordGenerator
{
    static class outils
    {
        public static int AskPositiveNumberNotNull(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue, "ERREUR : Le nombre doit être positif et non nul");
        }
        public static int AskNumberBetween(string question, int min, int max, string customError = null)
        {
            int userAnswer = AskNumber(question);

            while (userAnswer < min || userAnswer > max)
            {
                if (customError == null)
                {
                    Console.WriteLine($"ERREUR le nombre doit etre compris entre {min} et {max}\n");

                }
                else
                {
                    Console.WriteLine(customError);
                }
                userAnswer = AskNumber(question);
            }

            return userAnswer;
        }

        static int AskNumber(string question)
        {

            int result = 0;

            while (true)
            {
                Console.Write(question);
                string userAnswer = Console.ReadLine();
                try
                {
                    result = int.Parse(userAnswer);
                    return result;
                }
                catch
                {
                    Console.WriteLine("ERREUR : vous devez rentrer un nombre");
                }
            }
        }
    }
}
