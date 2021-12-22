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
    public partial class ListadoDeProductos : Form
    {
        public ListadoDeProductos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionVeterinariaDataSet);

        }

        private void ListadoDeProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionVeterinariaDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.gestionVeterinariaDataSet.Productos);

        }
    }
}
