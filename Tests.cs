using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    // 2 classe Tests
    class Tests
    {
        static void Main(string[] args)
        {     
            // test de la classe Adherent: constructeur et methodes
            Adherent adh1 = new Adherent("Dubois", "Eric", 111, 2016);
            Adherent adh2 = new Adherent("Paul", "Ménard", 075, 2011);
            Adherent adh3 = new Adherent("Noah", "Léo", 075, 2016);           

             Console.WriteLine("---Test de la classe Adherent---");
             adh1.setCode(112);
             Console.WriteLine(adh1.getNom());
             Console.WriteLine(adh1.getPrenom());
             Console.WriteLine(adh1.getAnneeAd()+ "\n");
             Console.WriteLine(adh1.equals(adh2));
             Console.WriteLine(adh2.equals(adh3) + "\n");
             Console.WriteLine(adh1.toString() + "\n\n");           

            // test de la classe Association: constructeur et methode toString()  
            Adherent[] tabAdh = new Adherent[3];
            tabAdh[0] = adh1;
            tabAdh[1] = adh2;
            tabAdh[2] = adh3;
            
            Console.WriteLine("---Test de la classe Association---");
            Association asso = new Association("Sport Montréal", 2000, 136,tabAdh);
            Console.WriteLine(asso.toString());             
        }
    }
}
