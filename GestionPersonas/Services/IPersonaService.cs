using GestionPersonas.Models;

namespace GestionPersonas.Services
{
    public interface IPersonaService
    {
        Task<List<Persona>> GetAllAsync();
        Task<Persona?> GetByIdAsync(string id);
        Task AddAsync(Persona persona);
        Task UpdateAsync(Persona persona);
        Task DeleteAsync(string id);
        bool PersonaExists(string id);
    }
}
