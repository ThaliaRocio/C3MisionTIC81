using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class DetailsUsuarioModel : PageModel
    {
        private readonly RepositorioUsuarios repositorioUsuario;
        public Usuario Usuario {get;set;}
 
        public DetailsUsuarioModel(RepositorioUsuarios repositorioUsuario)
        {
            this.repositorioUsuario = repositorioUsuario;
        }
 
        public IActionResult OnGet(int usuarioId)
        {
                Usuario = repositorioUsuario.GetWithId(usuarioId);
                return Page();
        }
    }
}
