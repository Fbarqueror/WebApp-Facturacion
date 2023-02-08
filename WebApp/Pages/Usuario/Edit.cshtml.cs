using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;

namespace WebApp.Pages.Usuario
{
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;

        public EditModel(ServiceApi service)
        {
            this.service = service;
        }



        [BindProperty]
        public UsuarioEntity Entity { get; set; } = new UsuarioEntity();
       
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.UsuarioGetById( id.Value );
                }

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

    }
}
