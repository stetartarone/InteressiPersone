namespace InteressiAlunni
{
    partial class InteressiPersone
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteressiPersone));
            this.lblNomePersona = new System.Windows.Forms.Label();
            this.txtNomeCognAl = new System.Windows.Forms.TextBox();
            this.gboxSex = new System.Windows.Forms.GroupBox();
            this.rdbFemmina = new System.Windows.Forms.RadioButton();
            this.rdbMaschio = new System.Windows.Forms.RadioButton();
            this.lblEta = new System.Windows.Forms.Label();
            this.cmbEta = new System.Windows.Forms.ComboBox();
            this.listPersone = new System.Windows.Forms.ListBox();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxCollezione = new System.Windows.Forms.CheckBox();
            this.chboxInformatica = new System.Windows.Forms.CheckBox();
            this.chboxSport = new System.Windows.Forms.CheckBox();
            this.chboxMusica = new System.Windows.Forms.CheckBox();
            this.chboxCinema = new System.Windows.Forms.CheckBox();
            this.chboxLeggere = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblNumRighe = new System.Windows.Forms.Label();
            this.gboxSex.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomePersona
            // 
            this.lblNomePersona.AutoSize = true;
            this.lblNomePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePersona.Location = new System.Drawing.Point(13, 13);
            this.lblNomePersona.Name = "lblNomePersona";
            this.lblNomePersona.Size = new System.Drawing.Size(207, 20);
            this.lblNomePersona.TabIndex = 0;
            this.lblNomePersona.Text = "Nome Cognome Persona";
            // 
            // txtNomeCognAl
            // 
            this.txtNomeCognAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCognAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCognAl.Location = new System.Drawing.Point(17, 37);
            this.txtNomeCognAl.Name = "txtNomeCognAl";
            this.txtNomeCognAl.Size = new System.Drawing.Size(259, 22);
            this.txtNomeCognAl.TabIndex = 1;
            // 
            // gboxSex
            // 
            this.gboxSex.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gboxSex.Controls.Add(this.rdbFemmina);
            this.gboxSex.Controls.Add(this.rdbMaschio);
            this.gboxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSex.ForeColor = System.Drawing.Color.IndianRed;
            this.gboxSex.Location = new System.Drawing.Point(17, 76);
            this.gboxSex.Name = "gboxSex";
            this.gboxSex.Size = new System.Drawing.Size(114, 56);
            this.gboxSex.TabIndex = 2;
            this.gboxSex.TabStop = false;
            this.gboxSex.Text = "Sesso";
            // 
            // rdbFemmina
            // 
            this.rdbFemmina.AutoSize = true;
            this.rdbFemmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemmina.ForeColor = System.Drawing.Color.Transparent;
            this.rdbFemmina.Location = new System.Drawing.Point(68, 19);
            this.rdbFemmina.Name = "rdbFemmina";
            this.rdbFemmina.Size = new System.Drawing.Size(38, 24);
            this.rdbFemmina.TabIndex = 1;
            this.rdbFemmina.TabStop = true;
            this.rdbFemmina.Text = "F";
            this.rdbFemmina.UseVisualStyleBackColor = true;
            // 
            // rdbMaschio
            // 
            this.rdbMaschio.AutoSize = true;
            this.rdbMaschio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaschio.ForeColor = System.Drawing.Color.Transparent;
            this.rdbMaschio.Location = new System.Drawing.Point(6, 19);
            this.rdbMaschio.Name = "rdbMaschio";
            this.rdbMaschio.Size = new System.Drawing.Size(41, 24);
            this.rdbMaschio.TabIndex = 0;
            this.rdbMaschio.TabStop = true;
            this.rdbMaschio.Text = "M";
            this.rdbMaschio.UseVisualStyleBackColor = true;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEta.Location = new System.Drawing.Point(13, 148);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(37, 20);
            this.lblEta.TabIndex = 3;
            this.lblEta.Text = "Eta";
            // 
            // cmbEta
            // 
            this.cmbEta.FormattingEnabled = true;
            this.cmbEta.Location = new System.Drawing.Point(12, 171);
            this.cmbEta.Name = "cmbEta";
            this.cmbEta.Size = new System.Drawing.Size(69, 21);
            this.cmbEta.TabIndex = 4;
            this.cmbEta.DropDown += new System.EventHandler(this.cmbEta_DropDown);
            // 
            // listPersone
            // 
            this.listPersone.FormattingEnabled = true;
            this.listPersone.Location = new System.Drawing.Point(308, 46);
            this.listPersone.Name = "listPersone";
            this.listPersone.Size = new System.Drawing.Size(480, 329);
            this.listPersone.TabIndex = 5;
            // 
            // btnCanc
            // 
            this.btnCanc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.ForeColor = System.Drawing.Color.Transparent;
            this.btnCanc.Image = ((System.Drawing.Image)(resources.GetObject("btnCanc.Image")));
            this.btnCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanc.Location = new System.Drawing.Point(308, 387);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(84, 51);
            this.btnCanc.TabIndex = 6;
            this.btnCanc.Text = "Canc";
            this.btnCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCanc.UseVisualStyleBackColor = false;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(398, 387);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 51);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Ordina";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.chboxCollezione);
            this.groupBox1.Controls.Add(this.chboxInformatica);
            this.groupBox1.Controls.Add(this.chboxSport);
            this.groupBox1.Controls.Add(this.chboxMusica);
            this.groupBox1.Controls.Add(this.chboxCinema);
            this.groupBox1.Controls.Add(this.chboxLeggere);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interessi Persone";
            // 
            // chboxCollezione
            // 
            this.chboxCollezione.AutoSize = true;
            this.chboxCollezione.ForeColor = System.Drawing.Color.Transparent;
            this.chboxCollezione.Location = new System.Drawing.Point(6, 156);
            this.chboxCollezione.Name = "chboxCollezione";
            this.chboxCollezione.Size = new System.Drawing.Size(119, 20);
            this.chboxCollezione.TabIndex = 5;
            this.chboxCollezione.Text = "Colezionismo";
            this.chboxCollezione.UseVisualStyleBackColor = true;
            // 
            // chboxInformatica
            // 
            this.chboxInformatica.AutoSize = true;
            this.chboxInformatica.ForeColor = System.Drawing.Color.Transparent;
            this.chboxInformatica.Location = new System.Drawing.Point(5, 130);
            this.chboxInformatica.Name = "chboxInformatica";
            this.chboxInformatica.Size = new System.Drawing.Size(200, 20);
            this.chboxInformatica.TabIndex = 4;
            this.chboxInformatica.Text = "Informatica Programmare";
            this.chboxInformatica.UseVisualStyleBackColor = true;
            // 
            // chboxSport
            // 
            this.chboxSport.AutoSize = true;
            this.chboxSport.ForeColor = System.Drawing.Color.Transparent;
            this.chboxSport.Location = new System.Drawing.Point(7, 103);
            this.chboxSport.Name = "chboxSport";
            this.chboxSport.Size = new System.Drawing.Size(63, 20);
            this.chboxSport.TabIndex = 3;
            this.chboxSport.Text = "Sport";
            this.chboxSport.UseVisualStyleBackColor = true;
            // 
            // chboxMusica
            // 
            this.chboxMusica.AutoSize = true;
            this.chboxMusica.ForeColor = System.Drawing.Color.Transparent;
            this.chboxMusica.Location = new System.Drawing.Point(7, 76);
            this.chboxMusica.Name = "chboxMusica";
            this.chboxMusica.Size = new System.Drawing.Size(145, 20);
            this.chboxMusica.TabIndex = 2;
            this.chboxMusica.Text = "Ascoltare Musica";
            this.chboxMusica.UseVisualStyleBackColor = true;
            // 
            // chboxCinema
            // 
            this.chboxCinema.AutoSize = true;
            this.chboxCinema.ForeColor = System.Drawing.Color.Transparent;
            this.chboxCinema.Location = new System.Drawing.Point(7, 49);
            this.chboxCinema.Name = "chboxCinema";
            this.chboxCinema.Size = new System.Drawing.Size(78, 20);
            this.chboxCinema.TabIndex = 1;
            this.chboxCinema.Text = "Cinema";
            this.chboxCinema.UseVisualStyleBackColor = true;
            // 
            // chboxLeggere
            // 
            this.chboxLeggere.AutoSize = true;
            this.chboxLeggere.ForeColor = System.Drawing.Color.Transparent;
            this.chboxLeggere.Location = new System.Drawing.Point(7, 22);
            this.chboxLeggere.Name = "chboxLeggere";
            this.chboxLeggere.Size = new System.Drawing.Size(114, 20);
            this.chboxLeggere.TabIndex = 0;
            this.chboxLeggere.Text = "Leggere libri";
            this.chboxLeggere.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(12, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 51);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Transparent;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(115, 387);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 51);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Inserisci";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(501, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 51);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salva";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsci.Image = ((System.Drawing.Image)(resources.GetObject("btnEsci.Image")));
            this.btnEsci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsci.Location = new System.Drawing.Point(594, 387);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(81, 51);
            this.btnEsci.TabIndex = 12;
            this.btnEsci.Text = "Esci";
            this.btnEsci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblNumRighe
            // 
            this.lblNumRighe.AutoSize = true;
            this.lblNumRighe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRighe.Location = new System.Drawing.Point(308, 14);
            this.lblNumRighe.Name = "lblNumRighe";
            this.lblNumRighe.Size = new System.Drawing.Size(177, 15);
            this.lblNumRighe.TabIndex = 13;
            this.lblNumRighe.Text = "Numero di Righe Presenti:";
            // 
            // InteressiPersone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lblNumRighe);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.listPersone);
            this.Controls.Add(this.cmbEta);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.gboxSex);
            this.Controls.Add(this.txtNomeCognAl);
            this.Controls.Add(this.lblNomePersona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InteressiPersone";
            this.Text = "Interessi Persone";
            this.gboxSex.ResumeLayout(false);
            this.gboxSex.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePersona;
        private System.Windows.Forms.TextBox txtNomeCognAl;
        private System.Windows.Forms.GroupBox gboxSex;
        private System.Windows.Forms.RadioButton rdbFemmina;
        private System.Windows.Forms.RadioButton rdbMaschio;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.ComboBox cmbEta;
        private System.Windows.Forms.ListBox listPersone;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chboxLeggere;
        private System.Windows.Forms.CheckBox chboxCollezione;
        private System.Windows.Forms.CheckBox chboxInformatica;
        private System.Windows.Forms.CheckBox chboxSport;
        private System.Windows.Forms.CheckBox chboxMusica;
        private System.Windows.Forms.CheckBox chboxCinema;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblNumRighe;
    }
}

