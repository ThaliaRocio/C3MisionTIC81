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
    public class ListUsuarioModel : PageModel
    {
        private readonly RepositorioUsuarios repositorioUsuarios;
        public IEnumerable<Usuario> Usuario {get;set;}

        [BindProperty]
        public Usuario objUsuario {get;set;}

        public ListUsuarioModel(RepositorioUsuarios repositorioUsuarios)
        {
            this.repositorioUsuarios = repositorioUsuarios;
        }


        public void OnGet()
        {
            Usuario = repositorioUsuarios.GetAll();
        }

        public IActionResult OnPost()
        {
            if(objUsuario.id>0)
            {
                objUsuario = repositorioUsuarios.Delete(objUsuario.id);
            }

            return RedirectToPage("./List");
        }
    }
}
