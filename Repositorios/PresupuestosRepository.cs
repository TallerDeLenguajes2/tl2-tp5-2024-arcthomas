
using espacioP;
using System.Data.SqlClient;
using espacioPDetalle;
using espacioProductos;
using Microsoft.Data.Sqlite;
using espacioInterfaz;

public class PresupuestosRepository : IPresupuestosRepository
{

    /*public List<Presupuestos> GetAll()
    public void Create(Presupuestos pres)
    {
        Console.Write("a");
    }
    public void Update(Presupuestos pres)
    {
        Console.Write("a");
    }
    {
    }*/
    public Presupuestos GetById(int id)
{
    string CadenaDeConexion = "Data Source=db/Tienda.db";
    using (SqliteConnection connection = new SqliteConnection(CadenaDeConexion))
    {
        string queryString = "SELECT NombreDestinatario FROM Presupuestos WHERE idPresupuesto = @id;";
        var command = new SqliteCommand(queryString, connection);
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        using (var reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                Presupuestos presupuesto = new Presupuestos();
                presupuesto.NombreDestinatario = reader[0].ToString();
                Console.WriteLine(reader[0]);
                return presupuesto;
            }
        }
    }
    return null;
}
    public void Delete(int id)
    {
    }
}
