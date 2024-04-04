using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Representation
    {
        DateTime moment;
        Film film;
        Salle salle;
        int nombreBilletsVendus;

        public Representation(DateTime moment, Film film, Salle salle)
        {
            Moment = moment;
            Film = film;
            Salle = salle;
            NombreBilletsVendus = 0; //pas obligatoire mais plus clair
        }

        public DateTime Moment { get => moment; set => moment = value; }
        public Film Film { get => film; set => film = value; }
        public Salle Salle { get => salle; set => salle = value; }
        public int NombreBilletsVendus { get => nombreBilletsVendus; set => nombreBilletsVendus = value; }

        private DateTime MomentFin { get => Moment.AddMinutes(film.DureeMinute); } //Moment est le début

        public override string? ToString()
        {
            return Moment.ToString() + ", " + Film.Nom + ", " + Film.ClassementFilm + ", " + Salle.Nom + ", " + nombreBilletsVendus + "/" + Salle.NombreDePlace;
        }

        public bool VerifierConflit(Representation representationAVerifier)
        {

            if (Salle == representationAVerifier.Salle)
            {  //le representation commence avec la representation a verifier && la fin termine avec le debut de la representation a verifier
               // OU la representation commence apres la fin de l'autre
                if (!((Moment <= representationAVerifier.Moment && MomentFin <= representationAVerifier.Moment) ||
                     Moment > representationAVerifier.MomentFin))
                {
                    return true;
                }

            }
            return false;
        }

    }
}
