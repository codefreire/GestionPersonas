using GestionPersonas.Models;

namespace GestionPersonas.Repositories
{
    public interface IPersonaRepository
    {
        Task<List<Persona>> GetAllAsync();
        Task<Persona> GetByIdAsync(string id);
        Task AddAsync(Persona persona);
        Task UpdateAsync(Persona persona);
        Task DeleteAsync(string id);
        bool PersonaExists(string id);
    }
}
