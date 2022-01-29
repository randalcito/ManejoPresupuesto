using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ManejoPresupuesto.Models
{
    public class CuentaCreacionViewModel: Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
