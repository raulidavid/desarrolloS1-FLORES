using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public DateTime FechaCompra { get; set; }

    public int ProveedorId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal TotalCompra { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Proveedore Proveedor { get; set; } = null!;
}
