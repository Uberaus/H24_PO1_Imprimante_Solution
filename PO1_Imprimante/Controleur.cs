using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Controleur
    {
        List<Salle> salles = new List<Salle>();
        List<Film> films = new List<Film>();
        List<Representation> representations = new List<Representation>();

        public Controleur()
        {
            //endroit pour remplir les controle a l'ouverture du programme
            salles.Add(new Salle("Salle 1", 50));
            salles.Add(new Salle("Salle 2", 40));
            salles.Add(new Salle("Salle 3", 25));

            films.Add(new Film("Star wars", 120, Film.Classement.TreizeEtPlus));
            films.Add(new Film("Die hard", 120, Film.Classement.SeizeEtPlus));
            films.Add(new Film("Minions", 120, Film.Classement.General));


        }

        public List<Salle> Salles { get => salles; set => salles = value; }
        public List<Film> Films { get => films; set => films = value; }
        public List<Representation> Representations { get => representations; set => representations = value; }


        public bool VerifierConflit(Representation nouvelleRepresentation)
        {
            foreach (Representation representationEnTraitement in representations)
            {
                //la responsabilité de vérifier le conflit est passé a lobjet representation lui-meme
                if (representationEnTraitement.VerifierConflit(nouvelleRepresentation))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
