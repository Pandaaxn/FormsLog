using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            FormLoggin formLoggin = new FormLoggin();
            this.Hide();
            formLoggin.Show();
        }
    }
}
