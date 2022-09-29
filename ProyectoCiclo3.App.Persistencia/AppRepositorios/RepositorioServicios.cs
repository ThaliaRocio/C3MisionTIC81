using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios = new List<Servicio>()
            {
                new Servicio{id=1, origen = 1, destino = 2, fecha = DateTime.Today, hora = "1000", encomienda = 1},
                new Servicio{id=2, origen = 2, destino = 3, fecha = DateTime.Today, hora = "0445", encomienda = 2},
                new Servicio{id=3, origen = 1, destino = 3, fecha = DateTime.Today, hora = "1912", encomienda = 3}
 
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }

        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(b => b.id == id);
        }

        public Servicio Update(Servicio newServicio){
            var servicio = servicios.SingleOrDefault(b => b.id == newServicio.id);
            if(servicio != null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
            }
            return servicio;
        }

        public Servicio Create(Servicio newServicio)
        {
            if(servicios.Count > 0){
                newServicio.id=servicios.Max(r => r.id) +1; 
            }else{
                newServicio.id = 1; 
            }
            servicios.Add(newServicio);
            return newServicio;
        }

        public Servicio Delete(int id)
        {
            var servicio = servicios.SingleOrDefault(b => b.id == id);
            servicios.Remove(servicio);
            return servicio;
        }
    }
}
