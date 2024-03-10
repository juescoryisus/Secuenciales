using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("datos.txt", true))
                {
                    string dato = txtDato.Text;
                    sw.WriteLine(dato);
                }

                MessageBox.Show("Dato escrito correctamente en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDato.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir en el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("datos.txt"))
                {
                    string contenido = sr.ReadToEnd();
                    MessageBox.Show("Contenido del archivo:\n" + contenido, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
