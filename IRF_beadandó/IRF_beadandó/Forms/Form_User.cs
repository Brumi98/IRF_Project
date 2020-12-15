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

                Szavazas();

                if (!ValidateFelhasznalo(txtFelhasznalo.Text))
                {
                    MessageBox.Show("Nem megfelelő felhasználónév!");
                }

                if (!ValidateJelszo(txtJelszo.Text))
                {
                    MessageBox.Show("A jelszó nem megfelelő");
                }


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
        public bool ValidateFelhasznalo(string Felhasználó)
        {
            return Regex.IsMatch(txtFelhasznalo.Text, "^[A-Z][a - zA - Z]* $");
        }

        public bool ValidateJelszo(string jelszo)
        {

            return Regex.IsMatch(txtJelszo.Text, $"[a - zA - Z0-9]* $");

        }

        public void txtFelhasznalo_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateFelhasznalo(txtFelhasznalo.Text))
            {
                MessageBox.Show("Nem megfelelő felhasználónév!");
            }
                
        }

        public void txtJelszo_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateJelszo(txtJelszo.Text))
            {
                MessageBox.Show("A jelszó nem megfelelő");
            }
        }
    }
}
