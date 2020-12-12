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
        //public User Register(string Felhasználó, string Jelszó)
        //{

        //    if (!ValidateNev(Felhasználó))
        //        throw new ValidationException("A megadott Név nem megfelelő!");
        //    if (!ValidateJelszo(Jelszó))
        //    {
        //        throw new ValidationException("A megadott jelszó nem megfelelő!");
        //    }
        //    var user = new User()
        //    {
        //        Felhasználó = Felhasználó,
        //        Jelszó = Jelszó
        //    };
           

        //}

        private void btnSzavazas_Click(object sender, EventArgs e)
        {
            CreateUser();
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


        //public bool ValidateNev(string Felhasználó)
        //{
        //    return Regex.IsMatch(Felhasználó, );


        //}

        //public bool ValidateJelszo(string Jelszó)
        //{

        //    return Regex.IsMatch(Jelszó, );


        //}
    }
}
