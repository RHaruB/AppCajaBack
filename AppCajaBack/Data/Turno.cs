namespace AppCajaBack.Data
{
    public class Turno
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } // Ej: AC0001
        public DateTime Fecha { get; set; } = DateTime.Now;

        public bool Atendido { get; set; } = false;

        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
