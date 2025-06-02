using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string telefono = textBox2.Text.Trim();
            string correo = textBox3.Text.Trim();


            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(telefono) && !string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("El contacto se guardo correctamente");
                listBox1.Items.Add($"{nombre} - {telefono} - {correo}");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            else
            {
                MessageBox.Show("Faltan datos por rellenar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona primero un Contacto a eliminar");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Aplicacion de registro de contactos");
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
