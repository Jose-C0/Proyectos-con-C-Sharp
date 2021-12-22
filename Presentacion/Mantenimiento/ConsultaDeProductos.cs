using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mantenimiento
{
    public partial class ConsultaDeProductos : Form
    {
        public ConsultaDeProductos()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void consultasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void consultasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void ConsultaDeProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionVeterinariaDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.gestionVeterinariaDataSet.Productos);
            // TODO: This line of code loads data into the 'gestionVeterinariaDataSet.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.gestionVeterinariaDataSet.Consultas);

        }
    }
}
