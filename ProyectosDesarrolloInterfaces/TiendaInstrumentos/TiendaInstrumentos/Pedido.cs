using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace TiendaInstrumentos
{

    using System;
    using System.Collections.Generic;

    public class Pedido
    {
        // Lista estática para almacenar todos los pedidos
        private static List<Pedido> pedidos = new List<Pedido>();

        // Propiedades de instancia
        public DateTime FechaPedido { get; private set; }
        public List<Producto> Productos { get; private set; }

        // Constructor para inicializar el pedido con la fecha actual
        public Pedido()
        {
            FechaPedido = DateTime.Now;
            Productos = new List<Producto>();
        }

        // Método para agregar un producto al pedido
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        // Método estático para agregar un pedido a la lista de pedidos
        public static void AgregarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        // Método estático para obtener todos los pedidos
        public static List<Pedido> ObtenerPedidos()
        {
            return pedidos;
        }
    }


}
