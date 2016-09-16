using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab14Set.Models;

namespace Lab14Set.Controllers
{
    public class MIversion2Controller : Controller
    {
        BD_B30355Entities baseDatos = new BD_B30355Entities();
        // GET: MIversion2
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaCLIENTES = baseDatos.CLIENTE.ToList();
            modelo.listaTelefonos = baseDatos.Telefono.ToList();
            modelo.listaCuentas = baseDatos.Cuenta.ToList();
            return View(modelo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.CLIENTE.Add(modelo.modeloCLIENTE);
                baseDatos.SaveChanges();
                if (modelo.modeloTelefono.NUMERO != null)
                {
                    modelo.modeloTelefono.CEDULAC = modelo.modeloCLIENTE.CEDULA;
                    baseDatos.Telefono.Add(modelo.modeloTelefono);
                }

                if (modelo.modeloTelefono2.NUMERO != null)
                {
                    modelo.modeloTelefono2.CEDULAC = modelo.modeloCLIENTE.CEDULA;
                    baseDatos.Telefono.Add(modelo.modeloTelefono2);
                }

                if (modelo.modeloCuenta.NUMEROCTA != null)
                {
                    modelo.modeloCuenta.Cedula = modelo.modeloCLIENTE.CEDULA;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta);
                }

                if (modelo.modeloCuenta2.NUMEROCTA != null)
                {
                    modelo.modeloCuenta2.Cedula = modelo.modeloCLIENTE.CEDULA;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta2);
                }

                if (modelo.modeloCuenta3.NUMEROCTA != null)
                {
                    modelo.modeloCuenta3.Cedula = modelo.modeloCLIENTE.CEDULA;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta3);
                }
                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }

    }


}