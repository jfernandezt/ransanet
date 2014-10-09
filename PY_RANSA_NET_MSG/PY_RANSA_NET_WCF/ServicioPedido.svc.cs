using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Messaging;
using PY_RANSA_NET_EN;
using PY_RANSA_NET_AD;
using System.ServiceModel.Activation;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPedido" in code, svc and config file together.
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioPedido
    {
      
        #region IServicioPedido Members
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Pedidos", ResponseFormat = WebMessageFormat.Json)]
        public Boolean RegistrarPedidoMovimiento(Cls_PedidoEN pedido)
        {
            string path = @".\private$\ransanet";
            MessageQueue cola = null;
            if (!MessageQueue.Exists(path))
            {
                MessageQueue.Create(path);
                cola = new MessageQueue(path);

            }
            else
                cola = new MessageQueue(path);

            Message mensaje = new Message();
            mensaje.Label = string.Format("Nuevo movimiento de pedido :{0}", pedido.IdPedido);
            mensaje.Body = pedido;
            cola.Send(mensaje);

            //Comsumir Servicio JAVA
            PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient lWs_RansaNet = 
                new PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient();

            string lStr_Mensaje = "";
            lStr_Mensaje = lWs_RansaNet.insertarPedidoMovimiento(pedido.IdPedido, pedido.IdEstadoPedido, pedido.IdUsuario);

            if (lStr_Mensaje.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Consultas", ResponseFormat = WebMessageFormat.Json)]
        public PY_RANSA_NET_WCF.Ws_RansaNet.PedidoMovimientoRansa[] ConsultaPedidoMovimiento(string pStr_CodPedido)
        {
            Cls_PedidoAD lObj_ClsPedidoAD = new Cls_PedidoAD();
            string rutaCola = @".\private$\ransanet";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            Message[] mensajes = cola.GetAllMessages();
            foreach (Message mensaje in mensajes)
            {
                cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cls_PedidoEN) });
                Message m = cola.Receive();
                Cls_PedidoEN pedido = (Cls_PedidoEN)m.Body;

                //lObj_ClsPedidoAD.RegistrarMovimientoPedido(pedido);
                
                //Comsumir Servicio JAVA
                PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient lWs_RansaNet = 
                    new PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient();
                string lStr_Mensaje = "";
                lStr_Mensaje = lWs_RansaNet.insertarPedidoMovimiento(pedido.IdPedido, (pedido.IdEstadoPedido + 1), pedido.IdUsuario);

            }

            //return lObj_ClsPedidoAD.ConsultarPedidoMovimiento(pStrCodPedido);
            PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient lWs_RansaNet2 = new PY_RANSA_NET_WCF.Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient();

            PY_RANSA_NET_WCF.Ws_RansaNet.PedidoMovimientoRansa[] lObj_PedidoMovimiento;

            lObj_PedidoMovimiento = lWs_RansaNet2.getPedidoMovimiento(pStr_CodPedido);

            return lObj_PedidoMovimiento;

        }

        #endregion

    }
}
