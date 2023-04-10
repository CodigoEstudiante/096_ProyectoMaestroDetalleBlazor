using BlazorMaster.Shared;

namespace BlazorMaster.Client.Servicio
{
    public interface IVentaService
    {
        Task<bool> Guardar(VentaDTO ventaDto);
    }
}
