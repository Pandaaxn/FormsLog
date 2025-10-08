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
        Acciones Acciones = new Acciones();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Acciones.AgregarNombre(txbNombre.Text))
            {
                MessageBox.Show("Nombre agregado con éxito");
                txbNombre.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar el nombre");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource = null;
            var nombres = Acciones.ObtenerNombres();

            if (nombres.Count > 0)
            {
                dgvNombres.DataSource = nombres.Select(n => new { Nombre = n }).ToList();
            }
            else
            {
                MessageBox.Show("No hay nombres para mostrar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Acciones.EliminarNombre(txbEliminar.Text))
            {
                MessageBox.Show("Nombre eliminado con éxito");
                txbEliminar.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar el nombre");
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar nombres en Excel";
                saveFileDialog.FileName = "Nombres.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;
                    if (Acciones.ExportarNombresAExcel(rutaArchivo))
                        MessageBox.Show("Exportación exitosa");
                    else
                        MessageBox.Show("Error al exportar");
                }
            }
        }
    }
}

