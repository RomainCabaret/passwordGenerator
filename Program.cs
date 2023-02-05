using System;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int NB_PASSWORD = 4;

            const int MINCHOICE = 1;
            const int MAXCHOICE = 4;


            int passwordLenght = outils.AskPositiveNumberNotNull("Longeur du mot de passe : ");
            int userChoice = outils.AskNumberBetween("\nVous voulez un mot de passe avec :\n" +
                "1 - Uniquement des caractères en minuscule \n" +
                "2 - Des caractères minuscules et majuscules \n" +
                "3 - Des caractères et des chiffres \n" +
                "4 - Caractère, chiffres et caractères spéciaux \n" +
                "Votre choix : ", MINCHOICE, MAXCHOICE) ;

            string miniscules = "abcdefghijklmnopkrstuvwxyz";
            string majuscules = miniscules.ToUpper();
            string number = "0123456789";
            string specialChar = "#&+-*";

            string alphabet;

            Random rnd = new Random();

            switch (userChoice)
            {
                case 1:
                    alphabet = miniscules;
                    break;
                case 2:
                    alphabet = miniscules + majuscules;
                    break;
                case 3:
                    alphabet = miniscules + number + number;
                    break;
                default:
                    alphabet = miniscules + number + number + specialChar;
                    break;
            }

            int alphabetlenght = alphabet.Length;

            for(int i = 0; i < NB_PASSWORD; i++)
            {
                string password = "";

                for (int j = 0; j < passwordLenght; j++)
                {
                    int index = rnd.Next(0, alphabetlenght);

                    password += alphabet[index];
                }
                Console.WriteLine($"\n - {password}");
            }
        }
    }
}