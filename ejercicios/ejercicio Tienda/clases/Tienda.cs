using System;
using System.Collections.Generic;

namespace ejercicio_Tienda.clases
{ 
    public class Tienda
    {
        public List<Producto> productos { get; set; }
        public List<Categoria> categorias { get; set; }

        public Tienda () {}

    }
    
    /*var joinResult = productos.Join(
                categorias, 
                producto => producto.nombre,
                categoria => categoria.descripcion,
                (producto, categoria) => new
                                    {
                                        nombre = producto.nombre,
                                        descripcion = categoria.descripcion
                                    });*/
}