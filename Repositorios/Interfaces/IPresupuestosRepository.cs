using System.Collections;
using espacioP;
using espacioProductos;

namespace espacioInterfaz;

public interface IPresupuestosRepository
{
Presupuestos GetById(int id);
/* IEnumerable GetAll(); 
void Create(Productos producto);
void Update(Productos producto);
void Delete(int idUsuario);*/
} 