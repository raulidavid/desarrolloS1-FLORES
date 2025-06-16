using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime FechaVenta { get; set; }

    public int ClienteId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal TotalVenta { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Empleado Empleado { get; set; } = null!;
}
