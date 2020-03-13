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
        public string equals(Adherent adherentC)
        {
            if(this.code == adherentC.code)
            {
                return "les 2 adherents sont égaux";
            }
            else
            {
                return "les 2 adherents ne sont pas égaux";
            }                                   
        }
        // la méthode  toString()
        public string toString()
        {
            return "---l'adherent---\n\tNom : " + nom + "\n\tPrénom : " +
                prenom + "\n\tCode : " + code + "\n\tAnnée d'adhesion : \n\t" + anneeAd;
        }
    }
}
