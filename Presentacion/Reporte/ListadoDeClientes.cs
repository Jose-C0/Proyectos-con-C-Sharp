using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reporte
{
    public partial class ListadoDeClientes : Form
    {
        public ListadoDeClientes()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void ListadoDeClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionVeterinariaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.gestionVeterinariaDataSet.Clientes);

        }
    }
}
