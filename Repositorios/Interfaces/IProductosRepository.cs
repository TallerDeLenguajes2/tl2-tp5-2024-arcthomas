using System.Collections;
using espacioProductos;

namespace espacioInterfaz;

public interface IProductosRepository
{
Productos FindById(int id);
IEnumerable GetAll();
void Insert(Productos producto);
void Update(Productos producto);
void Delete(int idUsuario);
} 