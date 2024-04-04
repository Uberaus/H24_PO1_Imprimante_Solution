using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Imprimante
{
    public class Film
    {
        string nom;
        int dureeMinute; //variable doit contenir les unites pour plus de clareté
        Classement classementFilm;

        public Film(string nom, int dureeMinute, Classement classementFilm)
        {
            Nom = nom;
            DureeMinute = dureeMinute;
            ClassementFilm = classementFilm;
        }

        public string Nom { get => nom; set => nom = value; }
        public int DureeMinute { get => dureeMinute; set => dureeMinute = value; }
        public Classement ClassementFilm { get => classementFilm; set => classementFilm = value; }


        public enum Classement
        {
            General,
            TreizeEtPlus,
            SeizeEtPlus,
            DixHuitEtPlus
        }
        public override string? ToString()
        {
            return Nom + " avec une durée de " + DureeMinute;
        }
    }
}
