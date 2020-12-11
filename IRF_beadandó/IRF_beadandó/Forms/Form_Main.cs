using IRF_beadandó.Entities;
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

namespace IRF_beadandó
{
    public partial class Form_Main : Form
    {
        Random rnd = new Random();
        DatabaseEntities_1 context = new DatabaseEntities_1();
        private User user = new User();

        public Form_Main()
        {
            InitializeComponent();

            context.Users.Load();
            context.Candites.Load();
            //CreateChart();


            userBindingSource.DataSource = context.Users.Local;
            canditeBindingSource.DataSource = context.Candites.Local;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserCreater();

            userBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            userDataGridView.Refresh();

        }

        private void UserCreater()
        {
            
            user.Felhasználó = txtFelhasználó.Text;
            user.Jelszó = txtJelszo.Text;
            user.JelöltekFK = cmbJelolt.SelectedIndex + 1;

            userBindingSource.Add(user);
        }

        //private void CreateChart() 
        //{

        //}

    }
}
