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
            txtFelhasznalo_Validating();

        }

        private void txtFelhasznalo_Validating()
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(txtFelhasznalo.Text))
            {
               

                if (!String.IsNullOrWhiteSpace(txtFelhasznalo.Text))
                {
                    txtFelhasznalo.BackColor = Color.LightGreen;
                }
                else
                {
                    txtFelhasznalo.BackColor = Color.White;
                }

            }

            else
            {
                
                txtFelhasznalo.BackColor = Color.MediumVioletRed;
            }
        }

        private void CreateUser()
        {
            if (txtFelhasznalo.Text != "" && txtJelszo.Text != "")
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
            else
            {
                MessageBox.Show("Kötelező mezők nincsenek kitöltve!");
            }
        }

        private void Szavazas()
        {

            user.Felhasználó = txtFelhasznalo.Text;
            user.Jelszó = txtJelszo.Text;
            user.JelöltekFK = cmbJelolt.SelectedIndex + 1;

            userBindingSource.Add(user);

        }

        private void txtFelhasznalo_Validating(object sender, CancelEventArgs e)
        {

            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(txtFelhasznalo.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(txtFelhasznalo.Text))
                {
                    txtFelhasznalo.BackColor = Color.LightGreen;
                }
                else
                {
                    txtFelhasznalo.BackColor = Color.White;
                }

            }

            else
            {
                e.Cancel = true;
                txtFelhasznalo.BackColor = Color.MediumVioletRed;
            }

        }

        private void txtFelhasznalo_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
