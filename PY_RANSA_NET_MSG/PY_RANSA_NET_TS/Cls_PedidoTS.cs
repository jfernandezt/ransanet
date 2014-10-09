using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using PY_RANSA_NET_EN;

namespace PY_RANSA_NET_TS
{
    [TestClass]
    public class Cls_PedidoTS
    {

        public Cls_PedidoTS()
        {

        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void RegistrarPedidoMovimiento()
        {
            int idPedido = 1;
            int idEstadoPedido = 2;
            int idUsuario = 1;
            string postdata = "{\"IdPedido\":" + idPedido.ToString() + ",\"IdEstadoPedido\":" + idEstadoPedido.ToString() + ",\"IdUsuario\":" + idUsuario.ToString() + "}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:49839/ServicioPedido.svc/Pedidos");

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string result = reader.ReadToEnd();
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //int r = js.Deserialize<int>(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ConsultaPedidoMovimiento()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:49839/ServicioPedido.svc/Consultas");

            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string resultado = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Cls_PedidoEN pedido = js.Deserialize<Cls_PedidoEN>(resultado);
            Assert.AreEqual(1, pedido.IdPedido);
            Assert.AreEqual(2, pedido.IdEstadoPedido);
            Assert.AreEqual(1, pedido.IdUsuario);
        }


    }
}
