using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Producto
    {
        // Propiedades que representan las columnas de tu tabla de base de datos
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public bool Disponible { get; set; }

        // Constructor por defecto
        public Producto()
        {
            // Puedes inicializar propiedades si lo deseas
        }

        // Constructor con parámetros para inicializar todas las propiedades
        public Producto(string codigo, string nombre, string familia, string marca, float precio, bool disponible)
        {
            Codigo = codigo;
            Nombre = nombre;
            Familia = familia;
            Marca = marca;
            Precio = precio;
            Disponible = disponible;
        }

       

        

        public override string ToString()
        {
            return $"Código: {Codigo}, Nombre: {Nombre}, Familia: {Familia}, Marca: {Marca}, Precio: {Precio}, Disponible: {(Disponible ? "Sí" : "No")}";
        }
    }
   

}
