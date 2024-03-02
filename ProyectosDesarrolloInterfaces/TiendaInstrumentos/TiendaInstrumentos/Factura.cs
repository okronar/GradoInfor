using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    internal class Factura
    {
        public int FacturaId { get; set; }
        public string ClienteId { get; set; }
        public string Nombre { get; set; }
        public Factura()
        {



        }

        public Factura(int facturaId, string clienteId, string nombre)
        {
            FacturaId = facturaId;
            ClienteId = clienteId;
            Nombre = nombre;
        }
    }
}
