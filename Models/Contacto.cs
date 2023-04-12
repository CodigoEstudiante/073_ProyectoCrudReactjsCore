using System;
using System.Collections.Generic;

namespace ProyectoCRUD.Models
{
    public partial class Contacto
    {
        public int IdContacto { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
    }
}
