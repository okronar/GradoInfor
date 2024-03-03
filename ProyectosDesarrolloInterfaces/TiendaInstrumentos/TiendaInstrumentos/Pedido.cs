using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using TiendaInstrumentos;
namespace TiendaInstrumentos
{
   public class Pedido
   {
        // Propiedad de instancia para almacenar los productos en el pedido actual
        private List<Producto> Productos { get; set; }

        // Constructor para inicializar el pedido con una lista de productos vacía
        public Pedido()
        {
            Productos = new List<Producto>();
        }

        // Método para agregar un producto al pedido
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        // Método para borrar el último producto añadido al pedido
        public void BorrarUltimoProducto()
        {
            if (Productos.Count > 0)
            {
                Productos.RemoveAt(Productos.Count - 1);
                
            }
        }
       public int getCount() { return Productos.Count; }

       public List <Producto> getList() { return Productos; }
        public void LimpiarPedido()
        {
            Productos.Clear();
        }


    }
}


