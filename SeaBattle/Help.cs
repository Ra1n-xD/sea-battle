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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Hide();
            this.Hide();
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
