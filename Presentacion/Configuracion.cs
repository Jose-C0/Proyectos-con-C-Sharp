using CapaSoporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Nombre: " + UserLoginCache.Nombre + ", " + UserLoginCache.Apellido;
            label2.Text = "Correo: " + UserLoginCache.Correo;
            label3.Text = "Telefono: " + UserLoginCache.Telefono;

        }
    }
}
