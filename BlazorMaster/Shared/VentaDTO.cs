using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMaster.Shared
{
    public class VentaDTO
    {
        public string? Cliente { get; set; }

        public decimal? Total { get; set; }

        public virtual ICollection<DetalleVentaDTO> DetalleVenta { get; set; }
    }
}
