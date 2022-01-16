using Microsoft.AspNetCore.Mvc;
using ProyectoCoreEF.Models;
using ProyectoCoreEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCoreEF.Controllers
{
    public class HospitalesController : Controller
    {
        //ESTA CLASE UTILIZARA EL REPOSITORIO PARA DEVOLVER LOS DATOS
        private RepositoryHospital repo;
        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }
        public IActionResult Details (int idhospital)
        {
            Hospital hospital = this.repo.FindHospital(idhospital);
            return View(hospital);
        }
    }
}
