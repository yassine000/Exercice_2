using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    // 1.2 classe Association
    class Association
    {        
        private static int limiteAd = 1000;
        private string nom;
        private int dateCreation;
        private int nbAdherents;
        private Adherent[] adherents = new Adherent[limiteAd];

        // constructeur
        public Association(string nom, int dateCreation, int nbAdherents, Adherent[] adherents)
        {
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.nbAdherents = nbAdherents;
            this.adherents = adherents;
        }
        // la méthode  toString()
        public string toString()
        {
            string str;
            str = "---L'association---\nNom : " + nom + "\nDate de création : " +
                dateCreation + "\nNombre d'adherents : " + nbAdherents + "\n\t";
            for(int i = 0; i < adherents.Length; i++)
            {
                str += " " + (i + 1) + adherents[i].toString() +"\n\t";
            }
            return str;
        }
    }
}
