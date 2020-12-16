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
using IRF_beadandó.Forms;

namespace IRF_beadandó
{
    public partial class Form_Login : Form
    {
        DatabaseEntities_1 context = new DatabaseEntities_1();
        Main_User Gazda = new Main_User();
        

        public Form_Login()
        {
            InitializeComponent();
            
            Gazda.nev  = "";
            Gazda.jelszo  = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Gazda.nev  & txtPassword.Text == Gazda.jelszo)
            {

                this.Close();
                Form_Main fm = new Form_Main();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó");
            }

        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Elso fe = new Form_Elso();
            fe.Show();
        }
    }
}
