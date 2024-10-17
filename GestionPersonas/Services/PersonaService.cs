using GestionPersonas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPersonas.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly PersonasDBContext _context;

        public PersonaService(PersonasDBContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> GetAllAsync()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona?> GetByIdAsync(string id)
        {
            return await _context.Personas.FirstOrDefaultAsync(p => p.Cedula == id);
        }

        public async Task AddAsync(Persona persona)
        {
            _context.Add(persona);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Persona persona)
        {
            _context.Update(persona);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public bool PersonaExists(string id)
        {
            return _context.Personas.Any(e => e.Cedula == id);
        }
    }
}
