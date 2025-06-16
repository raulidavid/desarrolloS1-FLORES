using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
