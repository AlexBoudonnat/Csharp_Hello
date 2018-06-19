using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Boolean exit = false;

            // Création de l'ogjet message
            Message message = new Message();

            //Recuperation du message d'accueil
            string msg = message.GetHelloMessage();

            do
            {
                WriteLine(msg);
                WriteLine("pressez \"Enter\" pour reafficher le msg de bienvenue ou taper \"exit\" pour quitter l'app");

                string choice = ReadLine();

                while (choice != "" && choice != "exit")
                {
                    WriteLine("Veuillez entrer une commande valide");
                    choice = ReadLine();
                }

                if (choice == "exit")
                {
                    WriteLine("Aurevoir");
                    exit = true;
                } 

            } while (!exit);
        }


    }
}
