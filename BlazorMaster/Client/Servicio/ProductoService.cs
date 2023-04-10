
using BlazorMaster.Shared;
using System.Net.Http.Json;

namespace BlazorMaster.Client.Servicio
{
    public class ProductoService : IProductoService
    {
        private readonly HttpClient _http;

        public ProductoService(HttpClient http)
        {
            _http = http;
        }


        public async Task<List<ProductoDTO>> Lista()
        {
            var lista = new List<ProductoDTO>();

            lista = await _http.GetFromJsonAsync<List<ProductoDTO>>("api/Producto");

            return lista!;
        }
    }
}
