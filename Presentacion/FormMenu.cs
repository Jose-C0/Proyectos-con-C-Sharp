using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;
using Presentacion.Administracion;
using Presentacion.Ayuda;
using Presentacion.Mantenimiento;
using Presentacion.Reporte;

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            //Privilegios
       
            if (UserLoginCache.IdRol == 2)//supervisor
            {
                administraciónToolStripMenuItem.Enabled = false;
                configuraciónToolStripMenuItem.Enabled = false;

            }
            if (UserLoginCache.IdRol == 3)//agente
            {
                mantenimientoToolStripMenuItem.Enabled = false;

            }

        }

 

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        private void registroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistroDePacientes registroDePacientes = new RegistroDePacientes();
            registroDePacientes.MdiParent = this;
            registroDePacientes.Show();
          
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDePacientes R = new RegistroDePacientes();
            R.MdiParent = this;
            R.Show();
            
        }

        private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeProductos R = new ConsultaDeProductos();
            R.MdiParent = this;
            R.Show();
        }

        private void controlDeConsultasDeRecepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           ControlDeConsultasDeRecepción R = new ControlDeConsultasDeRecepción();
            R.MdiParent = this;
            R.Show();
        }

        private void inventarioDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioDePacientes R = new InventarioDePacientes();
            R.MdiParent = this;
            R.Show();

        }

        private void listadoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListadoDePacientes R = new ListadoDePacientes();
            R.MdiParent = this;
            R.Show();

        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeClientes R = new ListadoDeClientes();
            R.MdiParent = this;
            R.Show();

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeProductos R = new ListadoDeProductos();
            R.MdiParent = this;
            R.Show();
        }

        private void cRUDDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDDeUsuarios R = new CRUDDeUsuarios();
            R.MdiParent = this;
            R.Show();
        }

        private void cRUDDeRolesDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDDeRolesDeUsuarios R = new CRUDDeRolesDeUsuarios();
            R.MdiParent = this;
            R.Show();
        }

        private void gestionesDeRolesXUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionesDeRolesxUsuarios R = new GestionesDeRolesxUsuarios();
            R.MdiParent = this;
            R.Show();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion R = new Configuracion();
            R.MdiParent = this;
            R.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("La Ayuda y soporte técnico de Windows es el sistema de ayuda integrado de Windows.");
    
     
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Net Framework 4.7.2");

        }
    }
}
