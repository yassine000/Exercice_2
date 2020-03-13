using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    // 1.1 classe Adherent 
    class Adherent
    {
        private string nom;
        private string prenom;
        private int code;
        private int anneeAd;
        

        public Adherent(string nom, string prenom, int code, int anneeAd)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeAd = anneeAd;
            this.code = code;
        }

    }
}
