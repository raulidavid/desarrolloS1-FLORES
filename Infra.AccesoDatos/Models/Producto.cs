using System;
using System.Collections.Generic;

namespace Infra.AccesoDatos.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CategoriaId { get; set; }

    public decimal PrecioVenta { get; set; }

    public decimal PrecioCompra { get; set; }

    public int Stock { get; set; }

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
