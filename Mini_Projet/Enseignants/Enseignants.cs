using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Enseignants
    {
        private string Nom;
        private string Prenom;
        private string Email;
        private string Statut ="En cours";
        private int Id;
        private Departements Departement;

        public int PropId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string PropNom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string PropPrenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public string PropEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string PropStatut
        {
            get { return Statut; }
            set { Statut = value; }
        }
        public Departements PropDepartements
        {
            get { return Departement; }
            set { Departement = new Departements(value); }

        }
        public Enseignants() { }

        public Enseignants(string Name, string PreName, string Mail, string Stat, Departements NewDep)
        {
            Nom = Name;
            Prenom = PreName;
            Email = Mail;
            Statut = Stat;
            Departement = new Departements(NewDep);

        }
        public Enseignants(Enseignants NewEnseignant)
        {
            Id = NewEnseignant.PropId;
            Nom = NewEnseignant.PropNom;
            Prenom = NewEnseignant.PropPrenom;
            Email = NewEnseignant.PropEmail;
            Statut = NewEnseignant.PropStatut;
            Departement = new Departements(NewEnseignant.PropDepartements);

        }
    }
}
