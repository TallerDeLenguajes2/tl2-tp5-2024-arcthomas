using System.Collections.Generic;
using espacioPDetalle;

namespace espacioP;
public class Presupuestos
{
    private int idPresupuesto;
    private string nombreDestinatario;
    private List<PresupuestosDetalle> detalle;
    private DateTime fechacreacion;
    public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value;}
    public void MontoPresupuesto()
    {
    }
    public void MontoPresupuestoConIva()
    {
    }
    public void CantidadProductos()
    {
    }
}