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
        DatabaseEntities1 context = new DatabaseEntities1();


        public Form_Main()
        {
            InitializeComponent();

            context.Users.Load();

            usersBindingSource.DataSource = context.Users.Local;

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Candites' table. You can move, or remove it, as needed.
            this.canditesTableAdapter.Fill(this.databaseDataSet.Candites);

            this.usersTableAdapter.Fill(this.databaseDataSet.Users);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Felhasználó = felhasználóTextBox.Text;
            user.Jelszó = jelszóTextBox.Text;

            usersBindingSource.Add(user);

            usersBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            usersDataGridView.Refresh();
        }
    }
}
