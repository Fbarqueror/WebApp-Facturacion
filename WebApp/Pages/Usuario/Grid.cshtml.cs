using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Usuario
{
    public class GridModel : PageModel
    {

        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }



        public IEnumerable<UsuarioEntity> GridList { get; set; } = new List<UsuarioEntity>();


        public async Task<IActionResult> OnGet()
        {
            
            try
            {
                GridList = await service.UsuarioGet();                   

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
        
    }
}
