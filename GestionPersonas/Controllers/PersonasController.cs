using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionPersonas.Models;
using GestionPersonas.Services;

namespace GestionPersonas.Controllers
{
    public class PersonasController : Controller
    {
        private readonly IPersonaService _personaService;
        public PersonasController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            var personas = await _personaService.GetAllAsync();
            return View(personas);
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var persona = await _personaService.GetByIdAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cedula,Nombre,Apellido,Edad,Email")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                await _personaService.AddAsync(persona);
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var persona = await _personaService.GetByIdAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Cedula,Nombre,Apellido,Edad,Email")] Persona persona)
        {
            if (id != persona.Cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _personaService.UpdateAsync(persona);
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var persona = await _personaService.GetByIdAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _personaService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(string id)
        {
            return _personaService.PersonaExists(id);
        }
    }
}
