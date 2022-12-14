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
    public class ListEncomiendaModel : PageModel
    {
        private readonly RepositorioEncomiendas repositorioEncomiendas;
        public IEnumerable<Encomienda> Encomienda {get;set;}

        [BindProperty]
        public Encomienda objEncomienda {get;set;}

        public ListEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
        {
            this.repositorioEncomiendas = repositorioEncomiendas;
        }

        public void OnGet()
        {
            Encomienda = repositorioEncomiendas.GetAll();
        }

        public IActionResult OnPost()
        {
            if(objEncomienda.id>0)
            {
                objEncomienda = repositorioEncomiendas.Delete(objEncomienda.id);
            }

            return RedirectToPage("./List");
        }
    }
}
