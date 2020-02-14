using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Surveillances
    {
        int Id;
        Enseignants Enseignant;
        Seances Seance;
        Salles Salle;
        DateTime DateSurveillance;
        //oooooooooooooooooooooooooooo
        public int PropId
        {
            get { return Id; }
            set { Id = value; }
        }

        public DateTime PropDateSurveillance
        {
            get { return DateSurveillance; }
            set { DateSurveillance = value; }
        }

        public Enseignants PropEnseignant
        {
            get { return Enseignant; }
            set { Enseignant = new Enseignants(value); }
        }

        public Seances PropSeance
        {
            get { return Seance; }
            set { Seance = new Seances(value); }
        }

        public Salles PropSalle
        {
            get { return Salle; }
            set { Salle = new Salles(value); }
        }

        public Surveillances()
        {

        }

        public Surveillances(Enseignants Prof, Seances NewSeance, Salles NewSalles, DateTime DtSurveillance)
        {
            Enseignant = new Enseignants(Prof);
            Seance = new Seances(NewSeance);
            Salle = new Salles(NewSalles);
            DateSurveillance = DtSurveillance;
        }

        public Surveillances(Surveillances NewSurveillance)
        {
            Id = NewSurveillance.PropId;
            Enseignant = new Enseignants(NewSurveillance.PropEnseignant);
            Seance = new Seances(NewSurveillance.PropSeance);
            Salle = new Salles(NewSurveillance.PropSalle);
            DateSurveillance = NewSurveillance.PropDateSurveillance;

        }
    }
}
