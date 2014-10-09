using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PY_RANSA_NET_EN;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace PY_RANSA_NET_AD
{
    public class Cls_PedidoAD
    {
        private string CadenaConexion = "Server=127.0.0.1;Database=bd_ransanet;Uid=root;Pwd=123;Port=3306;";
        //private string CadenaConexion = ConfigurationManager.AppSettings.Get("CadenaConexion");
        MySqlCommand cmdMySql;
        private DataTable dt;

        public string RegistrarMovimientoPedido(Cls_PedidoEN  pedido)
        {

            string lStr_Mensaje = "";

            using (MySqlConnection conMySql = new MySqlConnection(CadenaConexion))
            {
                
                cmdMySql = new MySqlCommand();
                cmdMySql.CommandText = "usp_ins_pedidomovimiento";
                cmdMySql.CommandType = System.Data.CommandType.StoredProcedure;
                cmdMySql.Connection = conMySql;
                conMySql.Open();

                cmdMySql.Parameters.Clear();
                cmdMySql.Parameters.AddWithValue("pn_IdPedido", pedido.IdPedido);
                cmdMySql.Parameters.AddWithValue("pn_IdEstadoPedido", pedido.IdEstadoPedido);
                cmdMySql.Parameters.AddWithValue("pn_IdUsuario", pedido.IdUsuario);
                cmdMySql.Parameters.Add("oc_message_error", MySqlDbType.VarChar, 1000).Direction = System.Data.ParameterDirection.Output;

                cmdMySql.ExecuteNonQuery();

                lStr_Mensaje = (string)cmdMySql.Parameters["OC_MESSAGE_ERROR"].Value;
            }

            return lStr_Mensaje;

        }


        public List<Cls_PedidoEN> ConsultarPedidoMovimiento(string pStrCodPedido)
        {

            List<Cls_PedidoEN> lList_Pedido = new List<Cls_PedidoEN>();

            using (MySqlConnection conMySql = new MySqlConnection(CadenaConexion))
            {

                dt = new DataTable();
                cmdMySql = new MySqlCommand();
                cmdMySql.CommandText = "usp_lis_pedidomovimientoPorCodPedido";
                cmdMySql.CommandType = System.Data.CommandType.StoredProcedure;
                cmdMySql.Connection = conMySql;
                conMySql.Open();

                cmdMySql.Parameters.AddWithValue("pc_CodPedido", pStrCodPedido);

                Cls_PedidoEN pedido = new Cls_PedidoEN();
                using (MySqlDataReader reader = cmdMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pedido.IdPedido = reader.GetInt32(1);
                        pedido.IdEstadoPedido = reader.GetInt32(3);
                        pedido.IdUsuario = reader.GetInt32(8);

                        lList_Pedido.Add(pedido);

                    }
                }

                return lList_Pedido;

            }

        }

    }
}
