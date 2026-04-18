namespace AppCajaBack.Data
{
    public class Servicio
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Equipos { get; set; }
        public int VelocidadMbps { get; set; }

        public decimal Precio { get; set; }

        public bool Activo { get; set; } = true;
    }
}
