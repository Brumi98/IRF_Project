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
            GetJelolt();
            GetVote();


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

            Random rnd = new Random();
            string szam = listBoxCandite.Items.Count.ToString();

            szavazo.Felhasználó = txtFelhasználó.Text;
            szavazo.Jelszó = txtJelszo.Text;
            if (cmbJelolt.Enabled == true)
            {
                szavazo.JelöltekFK = cmbJelolt.SelectedIndex + 1;
            }
            else
            {
                szavazo.JelöltekFK = rnd.Next(1,Convert.ToInt32(szam));
            }

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

        private void GetJelolt()
        {
            var jelolt = from x in context.Candites
                         where x.Jelöltek.StartsWith(txtBoxCandite.Text)
                         select x.Jelöltek;

            listBoxCandite.DataSource = jelolt.Distinct().ToList();

        }

        private void GetVote()
        {
            var selectedjelolt = (string)listBoxCandite.SelectedItem;
            var jeloltszam = from x in context.Users
                             where x.JelöltekFK.ToString() == selectedjelolt
                             select x;

            userBindingSource.DataSource = jeloltszam.ToList();

            var szavazatszam = (from x in jeloltszam
                                group x by new { x.Candite.Jelöltek } into g
                                select new Candite()
                                {

                                    Jelöltek = g.Key.Jelöltek,
                                    Candites_ID = (from x in g
                                                   select x.JelöltekFK).Count()

                                });

            //canditeBindingSource.DataSource = szavazatszam.ToList();

            chartSzavazas.DataBind();
        }

        private void txtBoxCandite_TextChanged(object sender, EventArgs e)
        {
            GetJelolt();
        }

        private void checkBoxRandom_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked != true)
            {
                 cmbJelolt.Enabled = true;
            }
            else
            {
                cmbJelolt.Enabled = false;
            }

        }
    }
}
