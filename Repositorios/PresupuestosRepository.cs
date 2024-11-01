
public class PresupuestosRepository : IRepository
{

public void Create(Presupuestos pres)
{
}
public void Update(Presupuestos pres)
{
}
public List<Presupuestos> GetAll()
{
}
public Presupuestos GetById(int id)
{
    string CadenaDeConexion = "Data Source=InstitutoDb.db;Cache=Shared";
    using (SqlConnection connection = new SqlConnection(CadenaDeConexion))
{
    string queryString = "SELECT NombreDestinatario FROM Presupuestos  WHERE idPresupuesto = 1;";
    var command = new SqlCommand(queryString, connection);
    connection.Open();
    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
        } // Resultados obtenidos (1 fila por vez)
    }
    connection.Close();
}
}
public void Delete(int id)
{
}
    
}