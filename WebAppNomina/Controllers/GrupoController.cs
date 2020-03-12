using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNomina.Models;

namespace WebAppNomina.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        List<GrupoCLS> LisTgrupo = null;
        public ActionResult Index()
        {
            using (var db = new NominaEntities())
            {
                LisTgrupo = (from grupo in db.Grupo
                             select new GrupoCLS
                             {

                                 Id_grupo = grupo.Id_grupo,
                                 nomb_grupo = grupo.nomb_grupo,
                                 cod_grupo = grupo.cod_grupo
                             }).ToList();

            }
            return View(LisTgrupo);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(GrupoCLS grupoCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(grupoCLS);
            }
            else
            {
                using (var bdUser = new NominaEntities())
                {
                    Grupo oGrupo = new Grupo();
                    oGrupo.Id_grupo = oGrupo.Id_grupo;
                    oGrupo.nomb_grupo = oGrupo.nomb_grupo;
                    oGrupo.cod_grupo = oGrupo.cod_grupo;
                    bdUser.Grupo.Add(oGrupo);
                    bdUser.SaveChanges();
                }
                return RedirectToAction("Index");
            }          
        }
    }
}