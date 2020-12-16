using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó.Forms
{
    public partial class Form_User : Form
    {

        DatabaseEntities_1 context = new DatabaseEntities_1();
        User user = new User();


        public Form_User(bool isTest = false)
        {
            InitializeComponent();
            if (isTest)
                return;
            context.Users.Load();
            context.Candites.Load();

            userBindingSource.DataSource = context.Users.Local;
            canditeBindingSource.DataSource = context.Candites.Local;
        }

        //Szavazáshoz

        private void CreateUser()
        {
            if (txtFelhasznalo.Text != "" && txtJelszo.Text != "")
            {
                if (Felhasznaloellenorzes(txtFelhasznalo.Text) != true)
                {
                    MessageBox.Show("Helytelen Felhasználónév");
                }
                else
                {
                    if (Jelszoellenorzes(txtJelszo.Text) != true)
                    {
                        MessageBox.Show("Helytelen Jelszó!");
                    }
                    else
                    {

                        Szavazas();

                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("Köszönjük, hogy szavazott.");
                            userBindingSource.EndEdit();

                            Application.Exit();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kötelező mezők nincsenek kitöltve!");
            }
            return;
        }

        private void Szavazas()
        {

            user.Felhasználó = txtFelhasznalo.Text;
            user.Jelszó = txtJelszo.Text;
            user.JelöltekFK = (int)cmbJelolt.SelectedValue;

            userBindingSource.Add(user);

        }

        //Regex

        public bool Felhasznaloellenorzes(string felhasznalo)
        {

            return Regex.IsMatch(felhasznalo, @"^[A-ZÁÉÚŐÓÜÖÍ][a-záéúőóüöí]*$");

        }

        public bool Jelszoellenorzes(string jelszo)
        {

            return Regex.IsMatch(jelszo, @"(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).{0,}$");

        }

        //Gombok eseményei

        private void btnSzavazas_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void btnKijelentkezes_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Elso fe = new Form_Elso();
            fe.Show();
        }

        //Információs ikon eseményei

        private void pictureBox_Felhasznalo_MouseEnter(object sender, EventArgs e)
        {
            lblFelhasznalo_Info.Visible = true;
        }

        private void pictureBox_Felhasznalo_MouseLeave(object sender, EventArgs e)
        {
            lblFelhasznalo_Info.Visible = false;
        }

        private void pictureBox_Jelszo_MouseEnter(object sender, EventArgs e)
        {
            lblJelszo_Info.Visible = true;
        }

        private void pictureBox_Jelszo_MouseLeave(object sender, EventArgs e)
        {
            lblJelszo_Info.Visible = false;
        }

    }
}
