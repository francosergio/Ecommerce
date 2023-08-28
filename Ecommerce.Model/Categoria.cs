﻿using System;
using System.Collections.Generic;

namespace Ecommerce.Model;

public partial class Categoria
{
    public int Idcategoria { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}