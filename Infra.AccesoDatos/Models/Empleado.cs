using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string? Telefono { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public string Cargo { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
