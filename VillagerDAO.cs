using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class VillagerDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<Villager> GetAllVillagers()
        {
            List<Villager> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT Villager_Name, Species, Gender, Personality, Hobby, Birthday FROM Villager";
            SqlCommand sqlCommand = new(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Villager villager = new()
                    {
                        VillagerName = reader.GetString(0),
                        Species = reader.GetString(1),
                        Gender = reader.GetString(2),
                        Personality = reader.GetString(3),
                        Hobby = reader.GetString(4),
                        Birthday = reader.GetDateTime(5)
                    };
                    returnThese.Add(villager);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<VillagerID> GetAllVillagersID()
        {
            List<VillagerID> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT Villager_Name, Species, Gender, Personality, Hobby, Birthday, Villager_ID FROM Villager";
            SqlCommand sqlCommand = new(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VillagerID villager = new()
                    {
                        VillagerName = reader.GetString(0),
                        Species = reader.GetString(1),
                        Gender = reader.GetString(2),
                        Personality = reader.GetString(3),
                        Hobby = reader.GetString(4),
                        Birthday = reader.GetDateTime(5),
                        Villager_ID = reader.GetInt32(6)

                    };
                    returnThese.Add(villager);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<VillagerID> SearchAllVillagersID(string? searchbox)
        {
            List<VillagerID> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = @"SELECT Villager_Name, Species, Gender, Personality, Hobby, Birthday, Villager_ID
                                FROM Villager 
                                WHERE Villager_name LIKE '%' + @SearchPattern + '%'";

            SqlCommand sqlCommand = new(query, conn);
            sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    VillagerID villager = new()
                    {
                        VillagerName = reader.GetString(0),
                        Species = reader.GetString(1),
                        Gender = reader.GetString(2),
                        Personality = reader.GetString(3),
                        Hobby = reader.GetString(4),
                        Birthday = reader.GetDateTime(5),
                        Villager_ID = reader.GetInt32(6)

                    };
                    returnThese.Add(villager);
                }
            }
            conn.Close();
            return returnThese;
        }
    }
}