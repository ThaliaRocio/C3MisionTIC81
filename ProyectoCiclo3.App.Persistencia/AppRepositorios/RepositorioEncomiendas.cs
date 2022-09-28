using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomiendas
    {
        List<Encomienda> encomiendas;
 
    public RepositorioEncomiendas()
        {
            encomiendas = new List<Encomienda>()
            {
                new Encomienda{id=1, descripcion = "Nimbus 2000", peso = 2500, tipo = "Express Lechuza", presentacion = "caja rectangular grande"},
                new Encomienda{id=2, descripcion = "Huevo de oro", peso = 7000, tipo = "Express Tren Howargs", presentacion = "caja cuadrada"},
                new Encomienda{id=3, descripcion = "Varita de sauco", peso = 600, tipo = "Normal", presentacion = "caja rectangular"}
 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomiendas;
        }

        public Encomienda GetWithId(int id){
            return encomiendas.SingleOrDefault(b => b.id == id);
        }
    }
}
