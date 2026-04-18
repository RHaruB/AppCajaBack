namespace AppCajaBack.Data
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; } // ADMIN, GESTOR, CAJERO

        public bool Activo { get; set; } = true;
    }
}
