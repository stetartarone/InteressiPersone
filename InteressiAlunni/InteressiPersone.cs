using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace InteressiAlunni
{
    public partial class InteressiPersone : Form
    {
        public InteressiPersone()
        {
            InitializeComponent();
        }

        //Inserimento eta nella combobox
        private void cmbEta_DropDown(object sender, EventArgs e)
        {
            //Inserimento eta nella combobox
            cmbEta.Items.Clear();
            for (int i = 3; i <= 99; i++)
            {
                cmbEta.Items.Add(i);
            }
        }
        //Reset dei campi
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNomeCognAl.Text = "";
            cmbEta.Text = "";
            rdbMaschio.Checked = false;
            rdbFemmina.Checked = false;
            chboxCinema.Checked = false;
            chboxLeggere.Checked = false;
            chboxMusica.Checked = false;
            chboxSport.Checked = false;
            chboxInformatica.Checked = false;
            chboxCollezione.Checked = false;
        }

        //Pulsante per cancellare i dati
        private void btnCanc_Click(object sender, EventArgs e)
        {
            if (listPersone.SelectedIndex == -1)
            {
                MessageBox.Show("Nessun alunno selezionato.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int scegliere = listPersone.SelectedIndex;
            listPersone.Items.RemoveAt(scegliere);
            lblNumRighe.Text = "Numero di righe Presenti: " + listPersone.Items.Count.ToString();
        }
        //Pulsante per ordinare i dati
        private void btnOrder_Click(object sender, EventArgs e)
        {
            listPersone.Sorted = true;
        }
        //Pulsante per salvare i dati
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listPersone.Items.Count == 0)
            {
                MessageBox.Show("Nessun alunno da salvare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                    {
                        foreach (var item in listPersone.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                        writer.Close();
                    }
                    MessageBox.Show("Elenco alunni salvato con successo.", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Pulsante per inserire i dati
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Controllo campi obbligatori
            if (txtNomeCognAl.Text == "" || cmbEta.Text == "")
            {
                MessageBox.Show("Nome ed età sono obbligatori", this.Text);
                return;
            }
            string insriga = " ";
            insriga += txtNomeCognAl.Text + " - ";
            if (rdbMaschio.Checked)
            {
                insriga += " M - ";
            }
            else
            {
                insriga += " F -";
            }
            insriga += cmbEta.Text + " - " + " Anni " + " - ";
            string interessi = "";
            //Controllo checkbox interessi
            if (chboxLeggere.Checked)
            {
                interessi = interessi + chboxLeggere.Text + " ";
            }
            if (chboxCinema.Checked)
            {
                interessi = interessi + chboxCinema.Text + " ";
            }
            if (chboxMusica.Checked)
            {
                interessi = interessi + chboxMusica.Text + " ";
            }
            if (chboxSport.Checked)
            {
                interessi = interessi + chboxSport.Text + " ";
            }
            if (chboxInformatica.Checked)
            {
                interessi = interessi + chboxInformatica.Text + " ";
            }
            if (chboxCollezione.Checked)
            {
                interessi = interessi + chboxCollezione.Text + " ";
            }
            if (interessi != "")
            {
                insriga += "Interssi: " + interessi;
            }
            listPersone.Items.Add(insriga);
            lblNumRighe.Text = "Numero di righe Presenti: " + listPersone.Items.Count.ToString();
        }
        //Pulsante per uscire dal programma
        private void btnEsci_Click(object sender, EventArgs e)
        {
            DialogResult uscita = MessageBox.Show("Vuoi uscire dal programma?", "Uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (uscita == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
