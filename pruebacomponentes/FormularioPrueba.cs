using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentesPersonalizados;

namespace pruebacomponentes
{
    public partial class FormularioPrueba : Form
    {
        public FormularioPrueba()
        {
            InitializeComponent();
        }

        private void customTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidarRFC_Click(object sender, EventArgs e)
        {
            {
                string rfc = txtRFC.Text;
                string rfcCorregido = RFCValidator.CorregirRFC(rfc);

                if (RFCValidator.EsRFCValido(rfcCorregido))
                {
                    lblResultado.Text = $"RFC válido: {rfcCorregido}";
                    lblResultado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultado.Text = $"RFC inválido: {rfcCorregido}";
                    lblResultado.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}