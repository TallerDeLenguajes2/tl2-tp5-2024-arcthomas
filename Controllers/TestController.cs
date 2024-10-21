using Microsoft.AspNetCore.Mvc;
using espacioP;
using espacioPDetalle;
using espacioProductos;

[ApiController]
[Route("[controller]")]
public class Test : ControllerBase
{
    [HttpGet("test")]
    public void TestDb()
    {
        PresupuestosRepository test = new PresupuestosRepository();
        test.GetById(2);
    }
    [HttpGet("test2")]
    public void TestDb2(int id, string nombre, DateTime fecha)
    {
        PresupuestosRepository test = new PresupuestosRepository();
        Presupuestos pres = new Presupuestos();
        pres.FechaCreacion = fecha;
        pres.NombreDestinatario = nombre;
        pres.IdPresupuesto = id;
        test.Create(pres);
    }
}