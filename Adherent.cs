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
        
        // constructeur
        public Adherent(string nom, string prenom, int code, int anneeAd)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.code = code;
            this.anneeAd = anneeAd;           
        }
        // les méthode setCode(), getNom(), getPrenom() et getAnneeAd()
        public void setCode(int newCode)
        {
            this.code = newCode;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public int getAnneeAd()
        {
            return anneeAd;
        }
        // la méthode equals()
        public bool equals(Adherent adherent_1, Adherent adherent_2)
        {
            return (adherent_1.code == adherent_2.code);                        
        }
        // la méthode  toString()
        public string toString()
        {
            return "le nom de l'adherent est : " + nom + "\nle prénom de l'adherent est : " +
                prenom + "\nle code est : " + code + "\nl'année d'adhesion est : " + anneeAd;
        }
    }
}
