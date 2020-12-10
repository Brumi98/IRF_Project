using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" & txtPassword.Text == "Asdfg1234")
            {
                
                Form_Main fm = new Form_Main();

                DialogResult result = fm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó");
            }

        }
    }
}
