using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Encuestadora_Identity2.Data;
using Encuestadora_Identity2.Models;

namespace Encuestadora_Identity2.Controllers
{
    public class EncuestaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EncuestaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Encuesta
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.encuestas.ToListAsync());
        //}

        public async Task<IActionResult> Index(string userName)
        {
            var ApplicationUser = _context.usuarios.Single(i => i.UserName == userName);
            var encuestadoraDBContext = _context.encuestas.Where(e => e.ApplicationUserId == ApplicationUser.Id);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        // GET: Encuesta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        // GET: Encuesta/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //METODO GET CREATE con ViewBag, Parametro ClienteId y automatizaciones 29/06/2022
        //GET
        public IActionResult Create(string userName)
        {
            var encuesta = new Encuesta();
            var dias = 7;
            encuesta.datetimeCreacionEncuesta = DateTime.Now;
            var ApplicationUser = _context.usuarios.Single(i => i.UserName == userName);
            //encuesta.ApplicationUser = ApplicationUser;
            encuesta.ApplicationUserId = ApplicationUser.Id;
            ViewBag.ApplicationUserId = ApplicationUser.Id;
            ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_GRATIS;
            var precioCliente = PrecioCliente.CLIENTE_GRATIS;/*cliente.precioCliente;*/
            if (precioCliente == PrecioCliente.CLIENTE_ORO)
            {
                ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_ORO;
                dias = 21;
            }
            else if (precioCliente == PrecioCliente.CLIENTE_PLATA)
            {
                ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_PLATA;
                dias = 15;
            }
            encuesta.datetimeVencimientoEncuesta = encuesta.datetimeCreacionEncuesta.AddDays(dias);
            //ViewData["Clientes"] = new SelectList(_context.clientes.ToList(), "ClienteId", "nombreCliente");
            return View(encuesta);
        }

        // POST: Encuesta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta,ApplicationUserId")] Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                //encuesta.ApplicationUserId = _context.Users.Find()
                _context.Add(encuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Encuesta", new { id = encuesta.EncuestaId });
            }
            //ViewBag.cliente = encuesta.Cliente;
            return View(encuesta);
        }

        // GET: Encuesta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas.FindAsync(id);
            if (encuesta == null)
            {
                return NotFound();
            }
            return View(encuesta);
        }

        // POST: Encuesta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta")] Encuesta encuesta)
        {
            if (id != encuesta.EncuestaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuesta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestaExists(encuesta.EncuestaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(encuesta);
        }

        // GET: Encuesta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        // POST: Encuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuesta = await _context.encuestas.FindAsync(id);
            _context.encuestas.Remove(encuesta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncuestaExists(int id)
        {
            return _context.encuestas.Any(e => e.EncuestaId == id);
        }
    }
}
