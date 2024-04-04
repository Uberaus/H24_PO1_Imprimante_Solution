using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Vente
    {
        Representation representation;
        int nbBilletEnfant;
        int nbBillet;

        public Vente(Representation representation, int nbBilletEnfant, int nbBillet)
        {
            Representation = representation;
            NbBilletEnfant = nbBilletEnfant;
            NbBillet = nbBillet;
        }

        public Representation Representation { get => representation; set => representation = value; }
        public int NbBilletEnfant { get => nbBilletEnfant; set => nbBilletEnfant = value; }
        public int NbBillet { get => nbBillet; set => nbBillet = value; }

        public List<string> GenererBillet()
        {
            List<string> ligneAImprimer = new List<string>();
            ligneAImprimer.Add(representation.Film.Nom);
            ligneAImprimer.Add(representation.Salle.Nom);
            ligneAImprimer.Add(representation.Moment.ToString());
            ligneAImprimer.Add("Nombre d'adminssion général: " + nbBillet);
            ligneAImprimer.Add("Nombre d'adminssion enfant: " + nbBilletEnfant);


            return ligneAImprimer;
        }
        public Bitmap GenererCodeQR()
        {

        }
    }

}
