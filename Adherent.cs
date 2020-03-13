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
        private int anneeAd;
        private int code;

        public Adherent(string nom, string prenom, int anneeAd, int code)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeAd = anneeAd;
            this.code = code;
        }

    }
}
