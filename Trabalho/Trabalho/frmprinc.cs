using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmprinc : Form
    {
        public frmprinc()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            frmcad_usuario frm = new frmcad_usuario();
            frm.Show();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            frmcad_produto frm = new frmcad_produto();
            frm.Show();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            frmcad_pedido frm = new frmcad_pedido();
            frm.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            frmcad_usuario frm = new frmcad_usuario();
            frm.Show();
        }
    }
}
