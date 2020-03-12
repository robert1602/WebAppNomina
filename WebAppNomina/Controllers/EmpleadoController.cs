using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNomina.Models;  

namespace WebAppNomina.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        List<EmpleadoCLS> LisTempleado = null;
        public ActionResult Index()
        {            
            using (var db = new NominaEntities())
            {
                LisTempleado = (from empleado in db.Empleado
                                select new EmpleadoCLS
                                {

                                    Id_empleado = empleado.Id_empleado,
                                    nombre = empleado.nombre,
                                    apellido = empleado.apellido,
                                    cod_empleado = empleado.cod_empleado,
                                    area = empleado.area,
                                    Id_grupo = empleado.Id_grupo
                                }).ToList();
            }

            return View(LisTempleado);
        }


        public ActionResult Agregar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Agregar(EmpleadoCLS empleadoCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(empleadoCLS);
            }
            else
            {
                using (var bd = new NominaEntities())
                {
                    Empleado empleado = new Empleado();
                    empleado.nombre = empleadoCLS.nombre;
                    empleado.apellido = empleadoCLS.apellido;
                    empleado.cod_empleado = empleadoCLS.cod_empleado;
                    empleado.area = empleadoCLS.area;
                    empleado.Id_grupo = empleadoCLS.Id_grupo;
                    bd.Empleado.Add(empleado);
                    bd.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}