using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstruBankV2.Models;
using InstruBankV2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InstruBankV2.Controllers
{
    public class InstrumentController : Controller
    {


        private readonly InstrumentDBContext context;
        public InstrumentController(InstrumentDBContext context)
        {
            this.context = context;
        }

        // GET: InstrumentController
        public ActionResult Index()
        {
            List<Instrument> lista = context.Instruments.ToList();
            return View(lista);
        }

            

        // GET: InstrumentController/Create
        
        public ActionResult Create()
        {
            Instrument instrumento = new Instrument();
            return View(instrumento);
            
        }

        // POST: InstrumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instrument instrumento)
        {
            if (ModelState.IsValid)
            {
                context.Instruments.Add(instrumento);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", "Instrument");
            }
        }

        // GET: InstrumentController/Edit/5
        public ActionResult Edit(int id)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento == null)
            {
                return NotFound();
            }
            return View(instrumento);
        }

        // POST: InstrumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instrument instru1)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento != null)
            {
                instrumento.Nombre = instru1.Nombre;
                instrumento.Tipo = instru1.Tipo;
                instrumento.Marca = instru1.Marca;
                instrumento.Descripcion = instru1.Descripcion;
                instrumento.Precio = instru1.Precio;
                instrumento.Stock = instru1.Stock;
                context.SaveChanges();
                return RedirectToAction("Index");

            }

            return NotFound();
        }

        // GET: InstrumentController/Delete/5

        public IActionResult Delete(int id)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento == null)
            {
                return NotFound();
            }
            else
            {
                context.Instruments.Remove(instrumento);
                context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        
        //GET
        public IActionResult FindByName()
        {
            return View();
        }
        //POST
        [Route("Instrument/FindByName/{nombre?}")]
        [HttpPost]
        public IActionResult FindByName(string nombre)
        {
            if (nombre == null)
            {
                return RedirectToAction("Index");
            }

            List<Instrument> instruments = (from i in context.Instruments
                                            where i.Nombre == nombre
                                            select i
                                        ).ToList();

            return View("Index", instruments);

        }

    }
}
