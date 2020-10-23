using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMapas.Domain;
using AppMapas.Infraestructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppMapas.Controllers
{
    public class BarrioController : Controller
    {

        private DepartmentDbContext _departmentDbContext;

        public BarrioController(DepartmentDbContext departmentDbContext)
        {
            _departmentDbContext = departmentDbContext;

        }
        public IActionResult CreateBarrio()
        {
            List<Municipio> municipios = null;
           municipios = _departmentDbContext.Municipio.ToList();
            List<SelectListItem> items = municipios.ConvertAll(m => {
                return new SelectListItem()
                {
                    Text = m.Nombre.ToString(),
                    Value = m.Id.ToString(),
                    Selected = false

                };
            });
            ViewBag.items = items;
            return View();
        }
        public IActionResult CreateBarrio(Barrio barrio)
        {
            _departmentDbContext.Barrio.Add(barrio);
            _departmentDbContext.SaveChanges();

            return View(barrio);
        }
    }
}
