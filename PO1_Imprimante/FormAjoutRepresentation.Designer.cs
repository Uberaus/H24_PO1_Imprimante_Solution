namespace PO1_Imprimante
{
    partial class FormAjoutRepresentation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox_representationFilm = new ListBox();
            comboBox_representationSalle = new ComboBox();
            label_representationDateHeure = new Label();
            label_representationSalle = new Label();
            label_representationFilm = new Label();
            button_representationAjouter = new Button();
            errorProvider_ajoutRepresentation = new ErrorProvider(components);
            dateTimePicker_representationDate = new DateTimePicker();
            dateTimePicker_representationHeure = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajoutRepresentation).BeginInit();
            SuspendLayout();
            // 
            // listBox_representationFilm
            // 
            listBox_representationFilm.FormattingEnabled = true;
            listBox_representationFilm.Location = new Point(130, 12);
            listBox_representationFilm.Name = "listBox_representationFilm";
            listBox_representationFilm.Size = new Size(416, 104);
            listBox_representationFilm.TabIndex = 1;
            // 
            // comboBox_representationSalle
            // 
            comboBox_representationSalle.FormattingEnabled = true;
            comboBox_representationSalle.Location = new Point(130, 122);
            comboBox_representationSalle.Name = "comboBox_representationSalle";
            comboBox_representationSalle.Size = new Size(416, 28);
            comboBox_representationSalle.TabIndex = 2;
            // 
            // label_representationDateHeure
            // 
            label_representationDateHeure.AutoSize = true;
            label_representationDateHeure.Location = new Point(12, 161);
            label_representationDateHeure.Name = "label_representationDateHeure";
            label_representationDateHeure.Size = new Size(41, 20);
            label_representationDateHeure.TabIndex = 3;
            label_representationDateHeure.Text = "Date";
            // 
            // label_representationSalle
            // 
            label_representationSalle.AutoSize = true;
            label_representationSalle.Location = new Point(12, 125);
            label_representationSalle.Name = "label_representationSalle";
            label_representationSalle.Size = new Size(41, 20);
            label_representationSalle.TabIndex = 4;
            label_representationSalle.Text = "Salle";
            // 
            // label_representationFilm
            // 
            label_representationFilm.AutoSize = true;
            label_representationFilm.Location = new Point(12, 12);
            label_representationFilm.Name = "label_representationFilm";
            label_representationFilm.Size = new Size(37, 20);
            label_representationFilm.TabIndex = 5;
            label_representationFilm.Text = "Film";
            // 
            // button_representationAjouter
            // 
            button_representationAjouter.Location = new Point(130, 201);
            button_representationAjouter.Name = "button_representationAjouter";
            button_representationAjouter.Size = new Size(193, 29);
            button_representationAjouter.TabIndex = 6;
            button_representationAjouter.Text = "Ajouter la représentation";
            button_representationAjouter.UseVisualStyleBackColor = true;
            button_representationAjouter.Click += button_representationAjouter_Click;
            // 
            // errorProvider_ajoutRepresentation
            // 
            errorProvider_ajoutRepresentation.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_ajoutRepresentation.ContainerControl = this;
            // 
            // dateTimePicker_representationDate
            // 
            dateTimePicker_representationDate.CustomFormat = "";
            dateTimePicker_representationDate.Format = DateTimePickerFormat.Short;
            dateTimePicker_representationDate.Location = new Point(130, 156);
            dateTimePicker_representationDate.Name = "dateTimePicker_representationDate";
            dateTimePicker_representationDate.Size = new Size(145, 27);
            dateTimePicker_representationDate.TabIndex = 0;
            // 
            // dateTimePicker_representationHeure
            // 
            dateTimePicker_representationHeure.CustomFormat = "HH:mm";
            dateTimePicker_representationHeure.Format = DateTimePickerFormat.Custom;
            dateTimePicker_representationHeure.Location = new Point(281, 156);
            dateTimePicker_representationHeure.Name = "dateTimePicker_representationHeure";
            dateTimePicker_representationHeure.ShowUpDown = true;
            dateTimePicker_representationHeure.Size = new Size(145, 27);
            dateTimePicker_representationHeure.TabIndex = 7;
            // 
            // FormAjoutRepresentation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 264);
            Controls.Add(dateTimePicker_representationHeure);
            Controls.Add(button_representationAjouter);
            Controls.Add(label_representationFilm);
            Controls.Add(label_representationSalle);
            Controls.Add(label_representationDateHeure);
            Controls.Add(comboBox_representationSalle);
            Controls.Add(listBox_representationFilm);
            Controls.Add(dateTimePicker_representationDate);
            Name = "FormAjoutRepresentation";
            Text = "Ajout d'une représentation";
            Load += FormAjoutRepresentation_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajoutRepresentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox_representationFilm;
        private ComboBox comboBox_representationSalle;
        private Label label_representationDateHeure;
        private Label label_representationSalle;
        private Label label_representationFilm;
        private Button button_representationAjouter;
        private ErrorProvider errorProvider_ajoutRepresentation;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker_representationDate;
        private DateTimePicker dateTimePicker_representationHeure;
    }
}