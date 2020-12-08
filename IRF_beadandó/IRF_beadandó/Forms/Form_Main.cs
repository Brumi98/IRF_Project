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
           
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);

        }
    }
}
