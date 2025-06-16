using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Inventario
{
    public int InventarioId { get; set; }

    public int ProductoId { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public int Cantidad { get; set; }

    public string? Observacion { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}
