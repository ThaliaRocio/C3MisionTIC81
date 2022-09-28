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
    public class DetailsEncomiendaModel : PageModel
    {
        private readonly RepositorioEncomiendas repositorioEncomienda;
        public Encomienda Encomienda {get;set;}
 
        public DetailsEncomiendaModel(RepositorioEncomiendas repositorioEncomienda)
        {
            this.repositorioEncomienda = repositorioEncomienda;
        }
 
        public IActionResult OnGet(int encomiendaId)
        {
                Encomienda = repositorioEncomienda.GetWithId(encomiendaId);
                return Page();
        }
    }
}
