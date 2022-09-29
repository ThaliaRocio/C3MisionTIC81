using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
        public RepositorioUsuarios()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario{id=1, nombre = "Harry", apellidos = "Potter", direccion = "Prive Drive", telefono = "111 111 1111"},
                new Usuario{id=2, nombre = "Ron", apellidos = "Weasley", direccion = "La madriguera ", telefono = "222 222 222"},
                new Usuario{id=3, nombre = "Hermione", apellidos = "Granger", direccion = "Desconocido", telefono = "333 333 3333"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }

        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }

        public Usuario Update(Usuario newUsuario){
            var usuario = usuarios.SingleOrDefault(b => b.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
            }
            return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
            if(usuarios.Count > 0){
                newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
                newUsuario.id = 1; 
            }
            usuarios.Add(newUsuario);
            return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(b => b.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }
    }
}
