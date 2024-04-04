namespace PO1_Imprimante
{
    partial class FormPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_ajouter = new ToolStripMenuItem();
            ToolStripMenuItem_representation = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            imprimantesToolStripMenuItem = new ToolStripMenuItem();
            pOS58ToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            button_confirmerVente = new Button();
            textBox_vendreBilletEnfant = new TextBox();
            listBox_Representation = new ListBox();
            textBox_vendreBilletGenerale = new TextBox();
            label_NombreEnfants = new Label();
            label_nombreAdultes = new Label();
            errorProvider_Vente = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Vente).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_ajouter, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(762, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_ajouter
            // 
            ToolStripMenuItem_ajouter.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_representation });
            ToolStripMenuItem_ajouter.Name = "ToolStripMenuItem_ajouter";
            ToolStripMenuItem_ajouter.Size = new Size(72, 24);
            ToolStripMenuItem_ajouter.Text = "Ajouter";
            // 
            // ToolStripMenuItem_representation
            // 
            ToolStripMenuItem_representation.Name = "ToolStripMenuItem_representation";
            ToolStripMenuItem_representation.Size = new Size(192, 26);
            ToolStripMenuItem_representation.Text = "Représentation";
            ToolStripMenuItem_representation.Click += ToolStripMenuItem_representation_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimantesToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // imprimantesToolStripMenuItem
            // 
            imprimantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pOS58ToolStripMenuItem, pDFToolStripMenuItem });
            imprimantesToolStripMenuItem.Name = "imprimantesToolStripMenuItem";
            imprimantesToolStripMenuItem.Size = new Size(175, 26);
            imprimantesToolStripMenuItem.Text = "Imprimantes";
            // 
            // pOS58ToolStripMenuItem
            // 
            pOS58ToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pOS58ToolStripMenuItem.Name = "pOS58ToolStripMenuItem";
            pOS58ToolStripMenuItem.Size = new Size(144, 26);
            pOS58ToolStripMenuItem.Text = "POS-58";
            pOS58ToolStripMenuItem.Click += pOS58ToolStripMenuItem_Click;
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Font = new Font("Segoe UI", 9F);
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(144, 26);
            pDFToolStripMenuItem.Text = "PDF";
            pDFToolStripMenuItem.Click += pDFToolStripMenuItem_Click;
            // 
            // button_confirmerVente
            // 
            button_confirmerVente.Location = new Point(12, 227);
            button_confirmerVente.Name = "button_confirmerVente";
            button_confirmerVente.Size = new Size(207, 29);
            button_confirmerVente.TabIndex = 2;
            button_confirmerVente.Text = "Confirmer la vente";
            button_confirmerVente.UseVisualStyleBackColor = true;
            button_confirmerVente.Click += button_confirmerVente_Click;
            // 
            // textBox_vendreBilletEnfant
            // 
            textBox_vendreBilletEnfant.Location = new Point(228, 161);
            textBox_vendreBilletEnfant.Name = "textBox_vendreBilletEnfant";
            textBox_vendreBilletEnfant.Size = new Size(73, 27);
            textBox_vendreBilletEnfant.TabIndex = 3;
            // 
            // listBox_Representation
            // 
            listBox_Representation.FormattingEnabled = true;
            listBox_Representation.Location = new Point(12, 31);
            listBox_Representation.Name = "listBox_Representation";
            listBox_Representation.Size = new Size(702, 124);
            listBox_Representation.TabIndex = 4;
            // 
            // textBox_vendreBilletGenerale
            // 
            textBox_vendreBilletGenerale.Location = new Point(228, 194);
            textBox_vendreBilletGenerale.Name = "textBox_vendreBilletGenerale";
            textBox_vendreBilletGenerale.Size = new Size(73, 27);
            textBox_vendreBilletGenerale.TabIndex = 5;
            // 
            // label_NombreEnfants
            // 
            label_NombreEnfants.AutoSize = true;
            label_NombreEnfants.Location = new Point(12, 164);
            label_NombreEnfants.Name = "label_NombreEnfants";
            label_NombreEnfants.Size = new Size(128, 20);
            label_NombreEnfants.TabIndex = 6;
            label_NombreEnfants.Text = "Nombre d'enfants";
            // 
            // label_nombreAdultes
            // 
            label_nombreAdultes.AutoSize = true;
            label_nombreAdultes.Location = new Point(12, 197);
            label_nombreAdultes.Name = "label_nombreAdultes";
            label_nombreAdultes.Size = new Size(209, 20);
            label_nombreAdultes.TabIndex = 7;
            label_nombreAdultes.Text = "Nombre d'admission générale";
            // 
            // errorProvider_Vente
            // 
            errorProvider_Vente.ContainerControl = this;
            // 
            // FormPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 289);
            Controls.Add(label_nombreAdultes);
            Controls.Add(label_NombreEnfants);
            Controls.Add(textBox_vendreBilletGenerale);
            Controls.Add(listBox_Representation);
            Controls.Add(textBox_vendreBilletEnfant);
            Controls.Add(button_confirmerVente);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipale";
            Text = "Cinéma du coin";
            Load += FormPrincipale_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Vente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_ajouter;
        private ToolStripMenuItem ToolStripMenuItem_representation;
        private Button button_confirmerVente;
        private TextBox textBox_vendreBilletEnfant;
        private ListBox listBox_Representation;
        private TextBox textBox_vendreBilletGenerale;
        private Label label_NombreEnfants;
        private Label label_nombreAdultes;
        private ErrorProvider errorProvider_Vente;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem imprimantesToolStripMenuItem;
        private ToolStripMenuItem pOS58ToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
    }
}
