using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó.Forms
{
    public partial class Form_Elso : Form
    {

        public Form_Elso()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            HideForm();
            Form_Login fl = new Form_Login();

            DialogResult result = fl.ShowDialog();

            
        }

        private void HideForm()
        {

            this.Hide();


        }

        private void btnSzavaz_Click(object sender, EventArgs e)
        {
            HideForm();

            Form_User fu = new Form_User();

            DialogResult result = fu.ShowDialog();

        }
    }
}
