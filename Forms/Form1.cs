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
    public partial class FormLoggin : Form
    {
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUser.Text;
            string password = txbContraseña.Text;

            if (user == "Diane" && password == "123456")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                Inicio ventana = new Inicio();
                this.Hide();
                ventana.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
