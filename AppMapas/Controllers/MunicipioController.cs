using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMapas.Domain;
using AppMapas.Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AppMapas.Controllers
{
    public class MunicipioController : Controller
    {

        private DepartmentDbContext _departmentDbContext;

        public MunicipioController(DepartmentDbContext departmentDbContext)
        {
            _departmentDbContext = departmentDbContext;

        }
       
        
        public IActionResult CreateMunicipio()
        {
            List<Departamento> departamentos = null;
            departamentos = _departmentDbContext.Departamento.ToList();
            List<SelectListItem> items = departamentos.ConvertAll(d => {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false

                };
            }  );
            ViewBag.items = items;
            return View();
        }
        [HttpPost]
        public IActionResult CreateMunicipio(Municipio municipio)
        {
            
            _departmentDbContext.Municipio.Add(municipio);

            _departmentDbContext.SaveChanges();
            
            return View(municipio);
            
        }
    }
}
