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

        public Encomienda Update(Encomienda newEncomienda){
            var encomienda = encomiendas.SingleOrDefault(b => b.id == newEncomienda.id);
            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
            }
            return encomienda;
        }

        public Encomienda Create(Encomienda newEncomienda)
        {
            if(encomiendas.Count > 0){
                newEncomienda.id=encomiendas.Max(r => r.id) +1; 
            }else{
                newEncomienda.id = 1; 
            }
            encomiendas.Add(newEncomienda);
            return newEncomienda;
        }

        public Encomienda Delete(int id)
        {
            var encomienda = encomiendas.SingleOrDefault(b => b.id == id);
            encomiendas.Remove(encomienda);
            return encomienda;
        }
    }
}
