using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO1_Imprimante
{
    public partial class FormAjoutRepresentation : Form
    {



        Controleur controleur;

        public FormAjoutRepresentation(Controleur controleur)
        {
            InitializeComponent();
            this.controleur = controleur; //this fait référence a l,objet a la liste 18. Si la ligne 18 était controleurFilm et celui avec le this. controleurFilm. le this est pas nécéssaire.
        }

        private void FormAjoutRepresentation_Load(object sender, EventArgs e)
        {

            DateTime maintenant = DateTime.Now;
            dateTimePicker_representationHeure.Value = new DateTime(maintenant.Year,
                                                                           maintenant.Month,
                                                                           maintenant.Day,
                                                                           19, 00, 00);
            listBox_representationFilm.Items.AddRange(controleur.Films.ToArray());
            comboBox_representationSalle.Items.AddRange(controleur.Salles.ToArray());
        }

        private void button_representationAjouter_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            Film filmSelectionne = listBox_representationFilm.SelectedItem as Film;
            if (filmSelectionne != null)
            {
                errorProvider_ajoutRepresentation.SetError(this.listBox_representationFilm, String.Empty);
            }
            else
            {
                errorProvider_ajoutRepresentation.SetError(this.listBox_representationFilm, "Veuillez sélectionner un film");
                erreur = true;
            }
            Salle salleSelectionnee = comboBox_representationSalle.SelectedItem as Salle;
            if (salleSelectionnee != null)
            {
                errorProvider_ajoutRepresentation.SetError(this.comboBox_representationSalle, String.Empty);
            }
            else
            {
                errorProvider_ajoutRepresentation.SetError(this.comboBox_representationSalle, "Veuillez sélectionner une salle");
                erreur = true;
            }

            DateTime moment = new DateTime(
                    dateTimePicker_representationDate.Value.Year,
                    dateTimePicker_representationDate.Value.Month,
                    dateTimePicker_representationDate.Value.Day,
                    dateTimePicker_representationHeure.Value.Hour,
                    dateTimePicker_representationHeure.Value.Minute,
                    0
                );
            if (moment > DateTime.Now)
            {
                errorProvider_ajoutRepresentation.SetError(this.dateTimePicker_representationHeure, String.Empty);
            }
            else
            {
                errorProvider_ajoutRepresentation.SetError(this.dateTimePicker_representationHeure, "Veuillez sélectionner une date valide.");
                erreur = true;
            }
            //À compléter
            //Conflit (controleur)
            Representation nouvelleRepresentation = new Representation(moment, filmSelectionne, salleSelectionnee);

            if (controleur.VerifierConflit(nouvelleRepresentation))
            {
                errorProvider_ajoutRepresentation.SetError(this.button_representationAjouter, "Il y a un conflit avec cette representation");
            }
            else
            {
                controleur.Representations.Add(nouvelleRepresentation);
                this.Close();
            }

        }
    }
}


