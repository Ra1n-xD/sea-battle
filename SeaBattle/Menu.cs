using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Form1")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Game a = new Game();
                this.Hide();
                a.Show();
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Form1")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Help a = new Help();
                this.Hide();
                a.Show();
            }
        }

    }
}
