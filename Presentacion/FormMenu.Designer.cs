
namespace Presentacion
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeConsultasDeRecepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDeRolesDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionesDeRolesXUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.cambiarPasswordToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // cambiarPasswordToolStripMenuItem
            // 
            this.cambiarPasswordToolStripMenuItem.Name = "cambiarPasswordToolStripMenuItem";
            this.cambiarPasswordToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.cambiarPasswordToolStripMenuItem.Text = "Cambiar Password";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePacientesToolStripMenuItem,
            this.registroDeClientesToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.controlDeConsultasDeRecepciónToolStripMenuItem,
            this.inventarioDePacientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(115, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // registroDePacientesToolStripMenuItem
            // 
            this.registroDePacientesToolStripMenuItem.Name = "registroDePacientesToolStripMenuItem";
            this.registroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.registroDePacientesToolStripMenuItem.Text = "Registro de Pacientes";
            this.registroDePacientesToolStripMenuItem.Click += new System.EventHandler(this.registroDePacientesToolStripMenuItem_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem_Click);
            // 
            // controlDeConsultasDeRecepciónToolStripMenuItem
            // 
            this.controlDeConsultasDeRecepciónToolStripMenuItem.Name = "controlDeConsultasDeRecepciónToolStripMenuItem";
            this.controlDeConsultasDeRecepciónToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.controlDeConsultasDeRecepciónToolStripMenuItem.Text = "Control de Consultas de Recepción";
            this.controlDeConsultasDeRecepciónToolStripMenuItem.Click += new System.EventHandler(this.controlDeConsultasDeRecepciónToolStripMenuItem_Click);
            // 
            // inventarioDePacientesToolStripMenuItem
            // 
            this.inventarioDePacientesToolStripMenuItem.Name = "inventarioDePacientesToolStripMenuItem";
            this.inventarioDePacientesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.inventarioDePacientesToolStripMenuItem.Text = "Inventario de Pacientes";
            this.inventarioDePacientesToolStripMenuItem.Click += new System.EventHandler(this.inventarioDePacientesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePacientesToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDePacientesToolStripMenuItem
            // 
            this.listadoDePacientesToolStripMenuItem.Name = "listadoDePacientesToolStripMenuItem";
            this.listadoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.listadoDePacientesToolStripMenuItem.Text = "Listado de Pacientes";
            this.listadoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDePacientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de Productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDDeUsuariosToolStripMenuItem,
            this.cRUDDeRolesDeUsuariosToolStripMenuItem,
            this.gestionesDeRolesXUsuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // cRUDDeUsuariosToolStripMenuItem
            // 
            this.cRUDDeUsuariosToolStripMenuItem.Name = "cRUDDeUsuariosToolStripMenuItem";
            this.cRUDDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.cRUDDeUsuariosToolStripMenuItem.Text = "CRUD de Usuarios ";
            this.cRUDDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cRUDDeUsuariosToolStripMenuItem_Click);
            // 
            // cRUDDeRolesDeUsuariosToolStripMenuItem
            // 
            this.cRUDDeRolesDeUsuariosToolStripMenuItem.Name = "cRUDDeRolesDeUsuariosToolStripMenuItem";
            this.cRUDDeRolesDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.cRUDDeRolesDeUsuariosToolStripMenuItem.Text = "CRUD de Roles de Usuarios: ";
            this.cRUDDeRolesDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cRUDDeRolesDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionesDeRolesXUsuariosToolStripMenuItem
            // 
            this.gestionesDeRolesXUsuariosToolStripMenuItem.Name = "gestionesDeRolesXUsuariosToolStripMenuItem";
            this.gestionesDeRolesXUsuariosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.gestionesDeRolesXUsuariosToolStripMenuItem.Text = "Gestiones de Roles x Usuarios";
            this.gestionesDeRolesXUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionesDeRolesXUsuariosToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.acercaDelSistemaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            this.acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            this.acercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.acercaDelSistemaToolStripMenuItem.Text = "Acerca del Sistema";
            this.acercaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSistemaToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeConsultasDeRecepciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDeRolesDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionesDeRolesXUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
    }
}

