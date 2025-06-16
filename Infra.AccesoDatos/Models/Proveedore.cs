using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Proveedore
{
    public int ProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
