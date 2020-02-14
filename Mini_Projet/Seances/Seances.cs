using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Seances
    {
        private string Nom;
        private string Code;
        private string HeureDebut;
        private string HeureFin;

        public string PropNom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string PropCode
        {
            get { return Code; }
            set { Code = value; }
        }

        public string PropHeureDebut
        {
            get { return HeureDebut; }
            set { HeureDebut = value; }
        }

        public string PropHeureFin
        {
            get { return HeureFin; }
            set { HeureFin = value; }
        }

        public Seances() { }
        public Seances(string Name, string Cod, string HeureDeb, string HeureF)
        {
            Nom = Name;
            Code = Cod;
            HeureDebut = HeureDeb;
            HeureFin = HeureF;
        }
        public Seances(Seances NewSeance)
        {
            Code = NewSeance.PropCode;
            Nom = NewSeance.PropNom;
            HeureDebut = NewSeance.PropHeureDebut;
            HeureFin = NewSeance.PropHeureFin;
        }
    }
}
