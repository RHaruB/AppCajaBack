namespace AppCajaBack.Data
{
    public class Contrato
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime? FechaFin { get; set; }

        public string Estado { get; set; } // VIG, SUS, CAN

        public string FormaPago { get; set; }

        public bool Activo { get; set; } = true;
    }
}
