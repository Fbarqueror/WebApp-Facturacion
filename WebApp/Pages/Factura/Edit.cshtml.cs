using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;

namespace WebApp.Pages.Factura
{
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;

        public EditModel(ServiceApi service)
        {
            this.service = service;
        }



        [BindProperty]
        public FacturaEntity Entity { get; set; } = new FacturaEntity();
        public ProductoEntity Entity2 { get; set; } = new ProductoEntity();

        public IEnumerable<ProductoEntity> ProductoObtener { get; set; } = new List<ProductoEntity>();
        public IEnumerable<ProductoEntity> GridList2 { get; set; } = new List<ProductoEntity>();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.FacturaGetById(id.Value);
                    Entity2 = (ProductoEntity)await service.ProductoGet();
                }

                ProductoObtener = await service.ProductoGet();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

    }
}
