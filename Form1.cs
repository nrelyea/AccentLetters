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
            if (lowerCase)
            {
                Clipboard.SetText("á");
            }
            else
            {
                Clipboard.SetText("Á");

            }
        }

        private void e_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("é");
            }
            else
            {
                Clipboard.SetText("É");
            }
        }

        private void i_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("í");
            }
            else
            {
                Clipboard.SetText("Í");
            }
        }

        private void o_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("ó");
            }
            else
            {
                Clipboard.SetText("Ó");
            }
        }

        private void u_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("ú");
            }
            else
            {
                Clipboard.SetText("Ú");
            }
        }

        private void n_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("ñ");
            }
            else
            {
                Clipboard.SetText("Ñ");
            }
        }

        private void uu_button_Click(object sender, EventArgs e)
        {
            if (lowerCase)
            {
                Clipboard.SetText("ü");
            }
            else
            {
                Clipboard.SetText("Ü");
            }
        }

        private void exc_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("¡");
        }

        private void que_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("¿");
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

                lowerCase = true;
            }
        }


    }
}
