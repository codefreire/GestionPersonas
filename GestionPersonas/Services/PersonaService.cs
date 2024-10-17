using GestionPersonas.Models;
using GestionPersonas.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GestionPersonas.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public async Task<List<Persona>> GetAllAsync()
        {
            return await _personaRepository.GetAllAsync();
        }

        public async Task<Persona?> GetByIdAsync(string id)
        {
            return await _personaRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Persona persona)
        {
            await _personaRepository.AddAsync(persona);
        }

        public async Task UpdateAsync(Persona persona)
        {
            await _personaRepository.UpdateAsync(persona);
        }

        public async Task DeleteAsync(string id)
        {
            await _personaRepository.DeleteAsync(id);
        }

        public bool PersonaExists(string id)
        {
            return _personaRepository.PersonaExists(id);
        }
    }
}
