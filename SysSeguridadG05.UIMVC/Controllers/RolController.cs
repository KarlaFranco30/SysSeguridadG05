﻿using Microsoft.AspNetCore.Mvc;
//Referencia
using SysSeguridadG05.BL;
using SysSeguridadG05.EN;

namespace SysSeguridadG05.UIMVC.Controllers
{
    public class RolController : Controller
    {
        RolBL rolBl = new RolBL();
        public async Task<IActionResult> Index(Rol pRol = null)
        {
            if (pRol == null)
                pRol = new Rol();
            if (pRol.Top_Aux == 0)
                pRol.Top_Aux = 10;
            else
                if (pRol.Top_Aux == -1)
                pRol.Top_Aux = 0;
            var roles = await new RolBL().BuscarAsync(pRol);
            ViewBag.Top = pRol.Top_Aux;
            return View(roles);
        }

        public async Task<IActionResult> Details(int pId)
        {
            var rol = await rolBl.ObtenerPorId(new Rol { Id = pId });
            return View(rol);
        }

        public IActionResult Create(int pId)
        {
            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Rol pRol)
        {
            try
            {
                int result = await rolBl.CrearAsync(pRol);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
                return View(pRol);
            }
        }
    }
}
