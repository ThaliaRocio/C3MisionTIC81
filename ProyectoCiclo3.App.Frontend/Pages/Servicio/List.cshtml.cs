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
    public class ListServicioModel : PageModel
    {
        private readonly RepositorioServicios repositorioServicios;
        public IEnumerable<Servicio> Servicio {get;set;}

        [BindProperty]
        public Servicio objServicio {get;set;}

        public ListServicioModel(RepositorioServicios repositorioServicios)
        {
            this.repositorioServicios = repositorioServicios;
        }

        public void OnGet()
        {
            Servicio = repositorioServicios.GetAll();
        }

        public IActionResult OnPost()
        {
            if(objServicio.id>0)
            {
                objServicio = repositorioServicios.Delete(objServicio.id);
            }

            return RedirectToPage("./List");
        }
    }
}
