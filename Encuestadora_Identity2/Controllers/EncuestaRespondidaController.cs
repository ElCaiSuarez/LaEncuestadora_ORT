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
    public class EncuestaRespondidaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EncuestaRespondidaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EncuestaRespondida
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.encuestasRespondidas.Include(e => e.ApplicationUser).Include(e => e.encuesta).Include(e => e.opcionPregunta).Include(e => e.pregunta);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Resultado(string searchString, string userName)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewBag.ClienteId = userName;
            var encuestasRespondidas = from s in _context.encuestasRespondidas.Include(e => e.ApplicationUser).Include(e => e.encuesta).Include(e => e.opcionPregunta).Include(e => e.pregunta).OrderBy(e => e.PreguntaId).ThenBy(e => e.OpcionPreguntaId)
                                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                encuestasRespondidas = encuestasRespondidas.Where(s => s.encuesta.tituloEncuesta.Contains(searchString));

            }

            return View(await encuestasRespondidas.AsNoTracking().ToListAsync());
        }

        // GET: EncuestaRespondida/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas
                .Include(e => e.ApplicationUser)
                .Include(e => e.encuesta)
                .Include(e => e.opcionPregunta)
                .Include(e => e.pregunta)
                .FirstOrDefaultAsync(m => m.EncuestaRespondidaId == id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }

            return View(encuestaRespondida);
        }

        // GET: EncuestaRespondida/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.usuarios, "Id", "Id");
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta");
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion");
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta");
            return View();
        }

        // POST: EncuestaRespondida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,ApplicationUserId")] EncuestaRespondida encuestaRespondida)
        {
            if (ModelState.IsValid)
            {
                var ApplicationUser = _context.usuarios.Single(i => i.Id == encuestaRespondida.ApplicationUserId);
                _context.Add(encuestaRespondida);
                await _context.SaveChangesAsync();
                return RedirectToAction("ResponderPreguntas", "EncuestaRespondida", new { EncuestaId = encuestaRespondida.EncuestaId, userName = ApplicationUser.UserName });
            }
            //ViewData["ApplicationUserId"] = new SelectList(_context.usuarios, "Id", "Id", encuestaRespondida.ApplicationUserId);
            //ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            //ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            //ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        public IActionResult ResponderPreguntas(int EncuestaId, string userName)
        {
            //OTRA OPCION ES QUE EN DISPONIBLES NO LA MUESTRE
            var ApplicationUser = _context.usuarios.Single(i => i.UserName == userName);
            var encuesta = _context.encuestas
                    .Include(e => e.preguntas)
                    .ThenInclude(s => s.opciones)
                    .Single(m => m.EncuestaId == EncuestaId);
            var preguntas = encuesta.preguntas;
            var preguntasSinResponder = new List<Pregunta>();
            var preguntasinResponder = new Pregunta();
            var esEncuestaRespondida = false;
            ////Si no hay preguntas en la encuesta vuelve a disponibles
            //if (preguntas.Count > 0)
            //{
            foreach (Pregunta p in preguntas)
            {
                //Si la pregunta ya fue contestada por el usuario no la agrego a la lista de preguntasSinResponder
                if (!EncuestaRespondidaExists(encuesta.EncuestaId, ApplicationUser.Id, p.PreguntaId))
                {
                    //Agrego la pregunta a la lista de preguntasSinResponder
                    preguntasSinResponder.Add(p);
                }

            }
            //Si no hay preguntas sin responder en la encuesta vuelve a disponibles
            if (preguntasSinResponder.Count > 0)
            {
                preguntasinResponder = preguntasSinResponder.OfType<Pregunta>().FirstOrDefault();
                if (preguntasSinResponder.Count == 1)
                {
                    int puntos = (int)encuesta.puntosEncuesta;
                    ApplicationUser.sumarPuntosEncuesta(puntos);
                    _context.SaveChangesAsync();
                }
            }
            else
            {
                esEncuestaRespondida = true;
                return RedirectToAction("Disponible", "Encuesta", new { userName = userName, esEncuestaRespondida = esEncuestaRespondida });

            }
            // }
            var encuestaRespondida = new EncuestaRespondida();
            if (!esEncuestaRespondida)
            {
                encuestaRespondida.encuesta = encuesta;
                encuestaRespondida.EncuestaId = encuesta.EncuestaId;
                encuestaRespondida.ApplicationUser = ApplicationUser;
                encuestaRespondida.ApplicationUserId = ApplicationUser.Id;
                encuestaRespondida.datetimeRespuestaEncuesta = DateTime.Now;
                encuestaRespondida.pregunta = preguntasinResponder;
                encuestaRespondida.PreguntaId = preguntasinResponder.PreguntaId;
                ViewData["OpcionPreguntaId"] = new SelectList(preguntasinResponder.opciones, "OpcionPreguntaId", "tituloOpcion");
            }
            ViewBag.esEncuestaRespondida = esEncuestaRespondida;
            ViewBag.ApplicationUserId = ApplicationUser.Id;
            ViewBag.userName = ApplicationUser.UserName;
            return View(encuestaRespondida);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResponderPreguntas([Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,ApplicationUserId")] EncuestaRespondida encuestaRespondida)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(encuestaRespondida);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("ResponderPreguntas", "EncuestaRespondida", new { EncuestaId = encuestaRespondida.EncuestaId, userName = encuestaRespondida.ApplicationUserId });
        //    }
        //    return View(encuestaRespondida);
        //}

        // GET: EncuestaRespondida/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas.FindAsync(id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.usuarios, "Id", "Id", encuestaRespondida.ApplicationUserId);
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        // POST: EncuestaRespondida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,ApplicationUserId")] EncuestaRespondida encuestaRespondida)
        {
            if (id != encuestaRespondida.EncuestaRespondidaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuestaRespondida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestaRespondidaExists(encuestaRespondida.EncuestaRespondidaId))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.usuarios, "Id", "Id", encuestaRespondida.ApplicationUserId);
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        // GET: EncuestaRespondida/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas
                .Include(e => e.ApplicationUser)
                .Include(e => e.encuesta)
                .Include(e => e.opcionPregunta)
                .Include(e => e.pregunta)
                .FirstOrDefaultAsync(m => m.EncuestaRespondidaId == id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }

            return View(encuestaRespondida);
        }

        // POST: EncuestaRespondida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuestaRespondida = await _context.encuestasRespondidas.FindAsync(id);
            _context.encuestasRespondidas.Remove(encuestaRespondida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncuestaRespondidaExists(int id)
        {
            return _context.encuestasRespondidas.Any(e => e.EncuestaRespondidaId == id);
        }
        private bool EncuestaRespondidaExists(int EncuestaId, string userName, int PreguntaId)
        {
            
            return _context.encuestasRespondidas.Any(e => e.EncuestaId == EncuestaId && e.ApplicationUserId == userName && e.PreguntaId == PreguntaId);
        }

    }
}
