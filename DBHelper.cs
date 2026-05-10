using Microsoft.Data.SqlClient;
using System.Data;

namespace DentalClinicApp
{
    internal class DBHelper
    {
        private static string str = @"Server=localhost;Database=DentalClinic;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void SetData(string query)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); 
            }
        }
    }
}
public static class CurrentUser
{
    public static int UserID;
    public static string UserName;
    public static string UserRole;
    public static string Speciality; 
}