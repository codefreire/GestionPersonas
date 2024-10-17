namespace GestionPersonas.Models
{
    public partial class Persona
    {
        public string Cedula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Edad { get; set; }
        public string Email { get; set; } = null!;
    }
}
