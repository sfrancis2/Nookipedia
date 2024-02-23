using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class VillagerMuseumDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<VillagerMuseum> GetAllVillagers()
        {
            List<VillagerMuseum> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT VillagerID, MuseumID, DateFound FROM VillagersMuseum";
            SqlCommand sqlCommand = new(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VillagerMuseum villager = new()
                    {
                        Villager_ID = reader.GetInt32(0),
                        Museum_ID = reader.GetInt32(1),
                        DateFound = reader.GetDateTime(2)
                    };
                    returnThese.Add(villager);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<VillagerMuseumName> GetAllPMVillagers()
        {
            List<VillagerMuseumName> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = @"SELECT V.Villager_Name, DateFound FROM VillagersMuseum
                              JOIN Villager V ON VillagerID =Villager_ID";
            SqlCommand sqlCommand = new(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VillagerMuseumName villager = new()
                    {
                        Villager_Name = reader.GetString(0),
                        DateFound = reader.GetDateTime(1)
                    };
                    returnThese.Add(villager);
                }
            }
            conn.Close();
            return returnThese;
        }

        public void AddVillager(int vID, DateTime date)
        {
            SqlConnection conn = new(connectionString);
            string query = "INSERT INTO VillagersMuseum VALUES(@ID, 1, @date)";
            using (SqlCommand sqlCommand = new(query, conn))
            {
                sqlCommand.Parameters.AddWithValue("@ID", vID);
                sqlCommand.Parameters.AddWithValue("@date", date);
                conn.Open();
                int result = sqlCommand.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
            conn.Close();

        }
    }
}