using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accents
{
    public partial class Form1 : Form
    {

        public Boolean lowerCase = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void a_button_Click(object sender, EventArgs e)
        {

        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                a_button.Text = "Á";
                e_button.Text = "É";
                i_button.Text = "Í";
                o_button.Text = "Ó";
                u_button.Text = "Ú";
                n_button.Text = "Ñ";
                uu_button.Text = "Ü";
                lowerCase = false;
            }
            else
            {
                a_button.Text = "á";
                e_button.Text = "é";
                i_button.Text = "í";
                o_button.Text = "ó";
                u_button.Text = "ú";
                n_button.Text = "ñ";
                uu_button.Text = "ü";
                //exc_button.Text = "¡";
                //que_button.Text = "¿";
                lowerCase = true;
            }
        }
    }
}
