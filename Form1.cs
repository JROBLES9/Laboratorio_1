using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtIngresarDatos_Click(object sender, EventArgs e)
        {
            persona.Dpi = TxtDpi.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Apellido = TxtApellido.Text;
            persona.FechaNacimiento = DaTiFechaNacimiento.Value;
        }

        private void BtMostrarDatos_Click(object sender, EventArgs e)
        {
            LblDpi.Text = persona.Dpi;
            persona.normalizarNombre();
            LblNombre.Text = persona.Nombre;
            LblApellido.Text = persona.Apellido;
            LblFecha.Text = persona.FechaNacimiento.ToString();
            LblEdad.Text = persona.Edad().ToString();
        }
    }
}
