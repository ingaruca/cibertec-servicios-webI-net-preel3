using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.Entidades;
using Dominio.Repositorio;

namespace PreEL3.Controllers
{
    public class NegociosController : Controller
    {
        Pais_BL pais = new Pais_BL();
        Cliente_BL cliente = new Cliente_BL();

        // Listado de Cliente
        public ActionResult Listado()
        {
            return View(cliente.listado());
        }

        // Registrar Cliente
        public ActionResult Create()
        {
            ViewBag.paises = new SelectList(pais.listado(), "Idpais", "NombrePais");
            return View(new Cliente());
        }

        [HttpPost]
        public ActionResult Create(Cliente reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.paises = new SelectList(pais.listado(), "Idpais", "NombrePais");
                return View(reg);
            }

            ViewBag.mensaje = cliente.Agregar(reg);

            return RedirectToAction("Listado");
        }

        // Editar Cliente
        public ActionResult Edit(string id) 
        {
            Cliente reg = cliente.Registro(id);
            ViewBag.paises = new SelectList(pais.listado(), "Idpais", "NombrePais", reg.idpais);
            return View(reg);
        }

        [HttpPost]
        public ActionResult Edit(Cliente reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.paises = new SelectList(pais.listado(), "Idpais", "NombrePais", reg.idpais);
                return View(reg);
            }

            ViewBag.mensaje = cliente.Actualizar(reg);

            return RedirectToAction("Listado");
        }

        // Detalles del Cliente
        public ActionResult Details(string id)
        {
            return View(cliente.Registro(id));
        }

        // Eliminar Cliente
        public ActionResult Delete(string id)
        {
            Cliente reg = cliente.Registro(id);
            string mensaje = cliente.Eliminar(reg);

            return RedirectToAction("Listado");
        }
    }
}