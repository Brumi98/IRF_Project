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
        User szavazo = new User();

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

            if (txtFelhasználó.Text != "" && txtJelszo.Text != "")
            {
                UserCreater();

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Sikeres szavazó hozzáadás.");
                    userBindingSource.EndEdit();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ki kell tölteni az adatokat!");
            }

            userDataGridView.Refresh();

        }

        private void UserCreater()
        {
                szavazo.Felhasználó = txtFelhasználó.Text;
                szavazo.Jelszó = txtJelszo.Text;
                szavazo.JelöltekFK = cmbJelolt.SelectedIndex + 1;

                userBindingSource.Add(szavazo);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = userDataGridView.CurrentCell.RowIndex;
            userDataGridView.Rows.RemoveAt(rowIndex);

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

        //private void CreateChart() 
        //{

        //}

    }
}
