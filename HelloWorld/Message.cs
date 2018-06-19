using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Message
    {
        //On recupere le nom de l'utilisateur de l'ordi
        private string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        private string user = Environment.UserName;

        //Msg de bonjour défini par defaut au weekend
        private string bonjour = "Bon weekend";

        //On recupere l'heure et le jour actuel
        private int day = (int) DateTime.Now.DayOfWeek;
        private int hour = DateTime.Now.Hour;

        //Les differentes tranches horaires
        int morning, afternoon, night;
        
        public Message(int newMorning = 8, int newAfternoon = 13, int newNight = 18)
        {
            morning = newMorning;
            afternoon = newAfternoon;
            night = newNight;
        }

        //Fonction pour recuperer le message d'accueil
        public string GetHelloMessage()
        {

            //Pour les jours de Lundi à vendredi
            if (day > 0 && day <= 5)
            {
                if (hour >= afternoon && hour < night)
                {
                    bonjour = "Bon aprem";
                }
                else if (hour >= morning && hour < afternoon)
                {
                    bonjour = "Bonjour";
                }
                else
                {
                    //Pour le "bonsoir" du lundi au jeudi
                    if (day > 0 && day < 5)
                    { if (!(day == 1 && hour < morning))
                        {
                            bonjour = "Bonsoir";
                        }
                    }
                }
            }

            return (bonjour + ", " + user);
        }
    }
}
