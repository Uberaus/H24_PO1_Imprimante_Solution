using System.Drawing.Printing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PO1_Imprimante
{
    public partial class FormPrincipale : Form
    {

        Controleur controlleur;
        BindingSource bindingSourceRepresentation;

        public FormPrincipale()
        {
            InitializeComponent();
            controlleur = new Controleur();
            bindingSourceRepresentation = new BindingSource();
            /*bindingSourceRepresentation.DataSource = controlleur.Representations;
            listBox_Representation.DataSource = bindingSourceRepresentation;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Printing();
        }


        private void ToolStripMenuItem_representation_Click(object sender, EventArgs e)
        {
            FormAjoutRepresentation formAjoutRepresentation = new FormAjoutRepresentation(controlleur);
            DialogResult formAjoutRepresentationDialogResult = formAjoutRepresentation.ShowDialog();
            if (formAjoutRepresentationDialogResult == DialogResult.OK)
            {
                bindingSourceRepresentation.ResetBindings(false);
            }
        }

        private void button_confirmerVente_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            Representation representation = listBox_Representation.SelectedItem as Representation;
            if (representation == null)
            {
                errorProvider_Vente.SetError(this.listBox_Representation, "Vous devez sélectionner une représentation");
                erreur = true;
            }
            else
            {
                errorProvider_Vente.SetError(this.listBox_Representation, string.Empty);
            }
            int nbBilletsGenerales;
            bool parseNbBilletsGenerale = int.TryParse(textBox_vendreBilletGenerale.Text, out nbBilletsGenerales);
            if (!parseNbBilletsGenerale)
            {
                errorProvider_Vente.SetError(this.textBox_vendreBilletGenerale, "Nombre invalide.");
                erreur = true;
            }
            else
            {
                errorProvider_Vente.SetError(this.textBox_vendreBilletGenerale, string.Empty);
            }

            int nbBilletsEnfants;
            bool parseNbBilletsEnfants = int.TryParse(textBox_vendreBilletEnfant.Text, out nbBilletsEnfants);
            if (!parseNbBilletsEnfants)
            {
                errorProvider_Vente.SetError(this.textBox_vendreBilletEnfant, "Nombre invalide.");
                erreur = true;
            }
            if (!erreur)
            {
                try { 
                    //controlleur.VendreBillet(nbBilletsEnfants, nbBilletsGenerales, representation);
                    textBox_vendreBilletGenerale.Clear();
                    textBox_vendreBilletEnfant.Clear();
                    bindingSourceRepresentation.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    errorProvider_Vente.SetError(button_confirmerVente, ex.Message);
                }
                
            }

        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void pOS58ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlleur.DefinirImprimante("POS-58");
            pOS58ToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            pDFToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // controlleur.DefinirImprimante("Microsoft Print to PDF");
            pDFToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            pOS58ToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
        }
    }
}
