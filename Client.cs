using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.sarah
{
    internal class Client
    {

        //écrire les attributs de la classe
        public string nom { get; set; }
        public string prenom { get; set; }
        public string courriel { get; set; }
        public string carteCredit { get; set; }
        public int numeroDeChambre { get; set; }


        //écrire le constructeur qui initialise toutes les propriétés
        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroDeChambre)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.courriel = courriel;
            this.carteCredit = carteCredit;
            this.numeroDeChambre = numeroDeChambre;
        }
}
