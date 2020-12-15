using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using IRF_beadandó.Entities;
using IRF_beadandó.Forms;

namespace IRF_beadandó
{
    public partial class Form_User : Form
    {

        DatabaseEntities_1 context = new DatabaseEntities_1();
        User user = new User();


        public Form_User()
        {
            InitializeComponent();

            context.Users.Load();
            context.Candites.Load();

            userBindingSource.DataSource = context.Users.Local;
            canditeBindingSource.DataSource = context.Candites.Local;

        }

        private void btnSzavazas_Click(object sender, EventArgs e)
        {

            CreateUser();

        }

        private void CreateUser()
        {
            if (txtFelhasznalo.Text != "" && txtJelszo.Text != "")
            {
                try
                {
                    Felhasznaloellenorzes(txtFelhasznalo.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    Jelszoellenorzes(txtJelszo.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

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
            else
            {
                MessageBox.Show("Kötelező mezők nincsenek kitöltve!");
            }
            return;
        }

        private void Szavazas()
        {

            user.Felhasználó = txtFelhasznalo.Text;

            user.JelöltekFK = cmbJelolt.SelectedIndex + 1;

            userBindingSource.Add(user);

        }
        public bool Felhasznaloellenorzes(string felhasznalo)
        {

                return Regex.IsMatch(felhasznalo, "^[A-ZÁÉÚŐÓÜÖÍ][a-záéúőóüöí]*$");

        }

        public bool Jelszoellenorzes(string jelszo)
        {
           
            return Regex.IsMatch(jelszo, "(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).{0,}$");

        }

    }
}
