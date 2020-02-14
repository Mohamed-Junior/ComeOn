using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Salles
    {
        private string Nom;
        private string Type;
        

        public string PropNom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string PropType
        {
            get { return Type; }
            set { Type = value; }
        }
        
        public Salles() { }
        public Salles(string Name, string Typ)
        {
            Nom = Name;
            Type = Typ;
        }

        public Salles(Salles NewSalle)
        {
            Nom = NewSalle.PropNom;
            Type = NewSalle.PropType;
        }
       
    }
}
