using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_1bis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            for (int i = 0; i < jours.Length; i++)

            {

                Console.WriteLine(jours[i]);

            }
        }
    }
}
