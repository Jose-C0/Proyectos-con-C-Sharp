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
    public partial class RegistroDeClientes : Form
    {
        public RegistroDeClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void RegistroDeClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionVeterinariaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.gestionVeterinariaDataSet.Clientes);

        }
    }
}
