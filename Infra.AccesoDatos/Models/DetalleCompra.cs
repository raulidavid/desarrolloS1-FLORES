﻿using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class DetalleCompra
{
    public int DetalleCompraId { get; set; }

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Compra Compra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
