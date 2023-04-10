using BlazorMaster.Shared;

namespace BlazorMaster.Client.Servicio
{
    public interface IProductoService
    {
        Task<List<ProductoDTO>> Lista();
    }
}
