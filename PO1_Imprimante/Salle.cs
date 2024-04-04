using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Salle
    {
        string nom;
        int nombreDePlace;

        public Salle(string nom, int nombreDePlace)
        {
            Nom = nom;
            NombreDePlace = nombreDePlace;
        }

        public string Nom { get => nom; set => nom = value; }
        public int NombreDePlace { get => nombreDePlace; set => nombreDePlace = value; }

        public override string? ToString()
        {
            return nom+ " avec "+ nombreDePlace + " places"; // display member aurait été bon aussi
        }
    }
}
