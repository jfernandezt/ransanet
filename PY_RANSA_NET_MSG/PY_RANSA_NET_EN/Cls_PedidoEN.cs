using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PY_RANSA_NET_EN
{
    [DataContract]
    public class Cls_PedidoEN
    {
        [DataMember]
        public int IdPedido { get; set; }

        [DataMember]
        public int IdEstadoPedido { get; set; }

        [DataMember]
        public int IdUsuario { get; set; }

    }
}
