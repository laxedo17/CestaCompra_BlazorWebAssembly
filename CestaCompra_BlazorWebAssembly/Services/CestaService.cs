using System;
using System.Collections.Generic;
using CestaCompra_BlazorWebAssembly.Models;

namespace CestaCompra_BlazorWebAssembly.Services
{
    public class CestaService : ICestaService
    {
        public IList<Producto> Cesta { get; private set; }
        public int Total { get; set; }
        public event Action OnChange;

        public CestaService()
        {
            Cesta = new List<Producto>();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        public void AddProducto(Producto producto)
        {
            Cesta.Add(producto);
            Total += producto.Precio;
            NotifyStateChanged();
        }

        public void DeleteProducto(Producto producto)
        {
            Cesta.Remove(producto);
            Total -= producto.Precio;
            NotifyStateChanged();
        }
    }
}
