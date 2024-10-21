
using espacioP;
using System.Data.SqlClient;
using espacioPDetalle;
using espacioProductos;
using Microsoft.Data.Sqlite;
using espacioInterfaz;

public class PresupuestosRepository : IPresupuestosRepository
{
    // Listar presupuestos
    /* public List<Presupuestos> GetAll()
    {
    } */
    //Crear presupuestos
    public void Create(Presupuestos pres)
    {
        string CadenaDeConexion = "Data Source=db/Tienda.db";
        using (SqliteConnection connection = new SqliteConnection(CadenaDeConexion))
        {
            string queryString = "INSERT INTO Presupuestos (idPresupuesto, NombreDestinatario, FechaCreacion) VALUES (@id, @nombreDest, @fecha)";
            var command = new SqliteCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", pres.IdPresupuesto);
            command.Parameters.AddWithValue("@nombreDest", pres.NombreDestinatario);
            string fecha = pres.FechaCreacion.Date.ToString("yyyy-MM-dd");
            command.Parameters.AddWithValue("@fecha", fecha);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    // public void Update(Presupuestos pres)
    // {
    //     Console.Write("a");
    // }
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
            connection.Close();
        }
        return null;
    }
    /*  public void Delete(int id)
     {
     } */
}
