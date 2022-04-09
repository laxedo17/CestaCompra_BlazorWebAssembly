using System;
using System.Collections.Generic;
using CestaCompra_BlazorWebAssembly.Models;

namespace CestaCompra_BlazorWebAssembly.Services
{
    public interface ICestaService
    {
        IList<Producto> Cesta { get; }
        int Total { get; set; }
        event Action OnChange;
        void AddProducto(Producto producto);
        void DeleteProducto(Producto producto);
    }
}
