using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClientDAO repo = new ClientDAO();
        bool bouton_ajout = false;
        bool bouton_suppr = false;
        bool bouton_modif = false;
        bool bouton_validation = false;
        string lettreok = @"^[a-zA-ZÀ-ÿ\s’-]{1,60}$";
        private void Form1_Load(object sender, EventArgs e)
        {

            Width = 400;


            List<Client> liste = new List<Client>();

            liste = repo.List();

            listBox1.ValueMember = "IdentifiantClient";
            listBox1.DisplayMember = "Affichage";
            listBox1.DataSource = repo.List();
            groupBox1.Enabled = false;
            textBox_nom.BackColor = Color.White;
            textBox_prenom.BackColor = Color.White;
            textBox_ville.BackColor = Color.White;


        }

        private void bouton_ajouter_Click(object sender, EventArgs e)
        {
            textBox_nom.Clear();
            textBox_prenom.Clear();
            textBox_ville.Clear();
            bouton_suppr = false;
            bouton_modif = false;

            Width = 650;

            bouton_ajout = true;
            textBox_nom.Focus();
            groupBox1.Enabled = true;
        }

        private void bouton_modifier_Click(object sender, EventArgs e)
        {
            bouton_suppr = false;
            bouton_ajout = false;

            Width = 650;
            Client modif = new Client();
            try
            {
                modif = repo.find((long)listBox1.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox_nom.Text = modif.NomDuClient;
            textBox_prenom.Text = modif.PrenomDuClient;
            textBox_ville.Text = modif.VilleDuClient;
            bouton_modif = true;
            textBox_nom.Focus();
            groupBox1.Enabled = true;
        }

        private void bouton_supprimer_Click(object sender, EventArgs e)
        {
            bouton_modif = false;
            bouton_ajout = false;
            Width = 650;

            Client suppr = new Client();
            try
            {
                suppr = repo.find((long)listBox1.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox_nom.Text = suppr.NomDuClient;
            textBox_prenom.Text = suppr.PrenomDuClient;
            textBox_ville.Text = suppr.VilleDuClient;
            bouton_suppr = true;
            groupBox1.Enabled = true;
        }

        private void bouton_ok_Click(object sender, EventArgs e)

        {
            Width = 400;
            if (textBox_nom.BackColor == Color.GreenYellow && textBox_prenom.BackColor == Color.GreenYellow && textBox_ville.BackColor == Color.GreenYellow)

            {
              
                    if (bouton_modif == true)
                    {

                        Client clientmodif = new Client();

                        clientmodif.NomDuClient = textBox_nom.Text;
                        clientmodif.PrenomDuClient = textBox_prenom.Text;
                        clientmodif.VilleDuClient = textBox_ville.Text;
                        clientmodif.IdentifiantClient = (long)listBox1.SelectedValue;
                        try
                        {
                            repo.update(clientmodif);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        listBox1.DataSource = repo.List();

                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_ville.Clear();
                    }
                    if (bouton_suppr == true)
                    {
                        Client clientsuprim = new Client();
                        clientsuprim.IdentifiantClient = (long)listBox1.SelectedValue;

                        try
                        {
                            repo.delete(clientsuprim);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        listBox1.DataSource = repo.List();
                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_ville.Clear();
                    }

                    if (bouton_ajout == true)
                    {
                        Client clientajoute = new Client();

                        clientajoute.NomDuClient = textBox_nom.Text;
                        clientajoute.PrenomDuClient = textBox_prenom.Text;
                        clientajoute.VilleDuClient = textBox_ville.Text;
                        //clientajoute.IdentifiantClient  ;

                        try
                        {
                            repo.insert(clientajoute);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        listBox1.DataSource = repo.List();
                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_ville.Clear();
                    }
                

            }

            else
            {
                MessageBox.Show("Les trois champs doivent etre rempli avec des caractères valides");
                textBox_nom.BackColor = Color.White;
                textBox_prenom.BackColor = Color.White;
                textBox_ville.BackColor = Color.White;
            }
                       
            textBox_nom.BackColor = Color.White;
            textBox_prenom.BackColor = Color.White;
            textBox_ville.BackColor = Color.White;
            groupBox1.Enabled = false;
        }

        private void bouton_annuler_Click(object sender, EventArgs e)
        {
            Width = 400;
            textBox_nom.Clear();
            textBox_prenom.Clear();
            textBox_ville.Clear();
            textBox_nom.BackColor = Color.White;
            textBox_prenom.BackColor = Color.White;
            textBox_ville.BackColor = Color.White;
            groupBox1.Enabled = false;
        }


        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_nom.Text, lettreok))
            {
                textBox_nom.BackColor = Color.Red;
                textBox_nom.Focus();

            }
            else
            {
                textBox_nom.BackColor = Color.GreenYellow;
                
            }
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_prenom.Text, lettreok))
            {
                textBox_prenom.BackColor = Color.Red;
                textBox_prenom.Focus();
            }
            else
            {
                textBox_prenom.BackColor = Color.GreenYellow;
                
            }
        }

        private void textBox_ville_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_ville.Text, lettreok))
            {
                textBox_ville.BackColor = Color.Red;
                textBox_ville.Focus();
            }
            else
            {
                textBox_ville.BackColor = Color.GreenYellow;
                

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client modif = new Client();
            try
            {
                modif = repo.find((long)listBox1.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox_nom.Text = modif.NomDuClient;
            textBox_prenom.Text = modif.PrenomDuClient;
            textBox_ville.Text = modif.VilleDuClient;
        }
    }
}
