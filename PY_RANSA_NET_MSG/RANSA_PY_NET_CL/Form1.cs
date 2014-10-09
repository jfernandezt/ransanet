using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PY_RANSA_NET_AD;
using PY_RANSA_NET_EN;

namespace RANSA_PY_NET_CL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_PedidoAD lObj_ClsPedidoAD = new Cls_PedidoAD();
            Cls_PedidoEN lObj_ClsPedidoEN = new Cls_PedidoEN();

            lObj_ClsPedidoEN.IdPedido = 1;
            lObj_ClsPedidoEN.IdEstadoPedido = 2;
            lObj_ClsPedidoEN.IdUsuario = 1;

            string lStr_Mensaje = "";

            lStr_Mensaje = lObj_ClsPedidoAD.RegistrarMovimientoPedido(lObj_ClsPedidoEN);

            if (lStr_Mensaje.Equals(""))
            {
                MessageBox.Show("Registro guardado satisfactoriamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Cls_PedidoAD lObj_ClsPedidoAD = new Cls_PedidoAD();
            List<Cls_PedidoEN> lLis_Pedido = new List<Cls_PedidoEN>();

            lLis_Pedido = lObj_ClsPedidoAD.ConsultarPedidoMovimiento("E0001");

            dataGridView1.DataSource = lLis_Pedido;

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            ServicioPedidoRansaNet.ServicioPedidoClient lObj_WSPedidoRansa = new ServicioPedidoRansaNet.ServicioPedidoClient();
            Cls_PedidoEN lObj_ClsPedidoEN = new Cls_PedidoEN();

            lObj_ClsPedidoEN.IdPedido = 1;
            lObj_ClsPedidoEN.IdEstadoPedido = 2;
            lObj_ClsPedidoEN.IdUsuario = 1;

            if (lObj_WSPedidoRansa.RegistrarPedidoMovimiento(lObj_ClsPedidoEN))
            {
                MessageBox.Show("Registro satisfactorio");
            }
            else
            {
                MessageBox.Show("Error al registrar");
            }

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ServicioPedidoRansaNet.ServicioPedidoClient lObj_WSPedidoRansa = new ServicioPedidoRansaNet.ServicioPedidoClient();
            List<Cls_PedidoEN> lLis_Pedido = new List<Cls_PedidoEN>();

            List<ServicioPedidoRansaNet.PedidoMovimientoRansa> lObj_PedidoMovimiento = new List<ServicioPedidoRansaNet.PedidoMovimientoRansa>();

            lObj_PedidoMovimiento = lObj_WSPedidoRansa.ConsultaPedidoMovimiento("E0001");

            dataGridView1.DataSource = lObj_PedidoMovimiento;

        }
    }
}
