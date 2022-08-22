using System.Data.SqlClient;
using MiPrimeraApi.Controllers;
using MiPrimeraApi.Model;

namespace MiPrimeraApi.Repository
{

    public static class VentaHandler
    {
        public const string ConnectionString = "Server=DESKTOP-NM1D9DV;Initial Catalog=SistemaGestion;Trusted_Connection=true";

        public static bool CargarVenta(Venta venta)
        {

            bool resultado = false;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "UPDATE [SistemaGestion].[dbo].[ProductoVendido] " + "WHERE Id = @id";

                SqlParameter idsqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt) {  Value = venta.Id};
                

                sqlConnection.Open();

                {
                    using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                    {
                        sqlCommand.Parameters.Add(idsqlParameter);
                        int numberOfRows = sqlCommand.ExecuteNonQuery();
                        if (numberOfRows > 0)
                        {
                            resultado = true;
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return resultado;
        }

    }
}