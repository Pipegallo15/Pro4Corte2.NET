using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMapas.Domain;
using AppMapas.Infraestructure;
using Microsoft.AspNetCore.Mvc;


namespace AppMapas.Controllers
{
    public class DepartamentoController : Controller
    {
        private DepartmentDbContext _departmentDbContext;

        public DepartamentoController(DepartmentDbContext departmentDbContext)
        {
            _departmentDbContext = departmentDbContext;

        }

        public IActionResult CreateDepartamento()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDepartamento(Departamento departamento)
        {
            _departmentDbContext.Departamento.Add(departamento);
            _departmentDbContext.SaveChanges();

            return View(departamento);
        }
    }
}
