using GestionPersonas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPersonas.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly PersonasDBContext _context;

        public PersonaRepository(PersonasDBContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> GetAllAsync()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona> GetByIdAsync(string id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task AddAsync(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Persona persona)
        {
            _context.Personas.Update(persona);
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
