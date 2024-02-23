using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class SeaCreatureMuseumDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<SeaCreatureMuseum> GetAllSeaCreature()
        {
            List<SeaCreatureMuseum> returnThese = new List<SeaCreatureMuseum>();

            //connect to Server
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT SeaCreatureMuseum.SeaCreatureID, SeaCreatureMuseum.Location, SeaCreatureMuseum.DateFound, SeaCreature.SeaCreature_name FROM SeaCreatureMuseum JOIN SeaCreature ON SeaCreatureMuseum.SeaCreatureID = SeaCreature.SeaCreature_ID";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    SeaCreatureMuseum SeaCreatureMuseum = new SeaCreatureMuseum
                    {
                        SeaCreatureName = reader.GetString(3),
                        SeaCreatureID = reader.GetInt32(0),
                        SeaCreatureLocation = reader.GetString(1),
                        SeaCreatureDate = reader.GetDateTime(2)
                    };
                    returnThese.Add(SeaCreatureMuseum);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<SeaCreatureMuseum> FilterSeaCreature(string? searchbox, int? month)
        {
            List<SeaCreatureMuseum> filterSeaCreature = new List<SeaCreatureMuseum>();
            string queryMonth = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name 
                        FROM 
                            SeaCreatureMuseum as SC 
                        JOIN 
                            SeaCreature AS F ON SC.SeaCreatureID = SeaCreature_ID
                        JOIN 
                            ActiveMonth AS AM ON F.SeaCreature_ID = AM.Creature_ID
                        WHERE
                            AM.Creature_Type = 'SeaCreature'
                            AND AM.ActiveMonthNum = @Month";

            string querySearch = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name
                        FROM 
                            SeaCreatureMuseum as SC
                        JOIN SeaCreature AS F ON SC.SeaCreatureID = F.SeaCreature_ID
                        WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'";

            string queryBoth = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name 
                        FROM 
                            SeaCreatureMuseum as SC 
                        JOIN 
                            SeaCreature AS F ON SC.SeaCreatureID = SeaCreature_ID
                        JOIN 
                            ActiveMonth AS AM ON F.SeaCreature_ID = AM.Creature_ID
                        WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'
                        AND AM.Creature_Type = 'SeaCreature'
                        AND AM.ActiveMonthNum = @Month";


            string queryAll = "SELECT SeaCreatureMuseum.SeaCreatureID, SeaCreatureMuseum.Location, SeaCreatureMuseum.DateFound, SeaCreature.SeaCreature_name " +
                                "FROM SeaCreatureMuseum JOIN SeaCreature ON SeaCreatureMuseum.SeaCreatureID = SeaCreature.SeaCreature_ID";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SeaCreatureMuseum SeaCreatureMuseum = new SeaCreatureMuseum
                        {
                            SeaCreatureName = reader.GetString(3),
                            SeaCreatureID = reader.GetInt32(0),
                            SeaCreatureLocation = reader.GetString(1),
                            SeaCreatureDate = reader.GetDateTime(2)
                        };
                        filterSeaCreature.Add(SeaCreatureMuseum);
                    }
                }
                conn.Close();
                return filterSeaCreature;
            }
            else if (month == null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreatureMuseum SeaCreatureMuseum = new SeaCreatureMuseum
                            {
                                SeaCreatureName = reader.GetString(3),
                                SeaCreatureID = reader.GetInt32(0),
                                SeaCreatureLocation = reader.GetString(1),
                                SeaCreatureDate = reader.GetDateTime(2)
                            };
                            filterSeaCreature.Add(SeaCreatureMuseum);
                        }
                    }
                    conn.Close();
                    return filterSeaCreature;
                }
            }
            else if (searchbox == null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreatureMuseum SeaCreatureMuseum = new SeaCreatureMuseum
                            {
                                SeaCreatureName = reader.GetString(3),
                                SeaCreatureID = reader.GetInt32(0),
                                SeaCreatureLocation = reader.GetString(1),
                                SeaCreatureDate = reader.GetDateTime(2)
                            };
                            filterSeaCreature.Add(SeaCreatureMuseum);
                        }
                    }
                    conn.Close();
                    return filterSeaCreature;
                }
            }
            else
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreatureMuseum SeaCreatureMuseum = new SeaCreatureMuseum
                            {
                                SeaCreatureName = reader.GetString(3),
                                SeaCreatureID = reader.GetInt32(0),
                                SeaCreatureLocation = reader.GetString(1),
                                SeaCreatureDate = reader.GetDateTime(2)
                            };
                            filterSeaCreature.Add(SeaCreatureMuseum);
                        }
                    }
                }
                conn.Close();
                return filterSeaCreature;
            }
        }

        public List<SeaCreatureMuseum> GetAllActiveSeaCreature()
        {
            List<SeaCreatureMuseum> returnThese = new List<SeaCreatureMuseum>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT SM.SeaCreatureID, SM.Location, SM.DateFound, S.SeaCreature_name
                                FROM SeaCreatureMuseum AS SM
                                JOIN SeaCreature AS S ON SM.SeaCreatureID = SeaCreature_ID
                                JOIN ActiveMonth AS AM ON AM.Creature_ID = S.SeaCreature_ID
                                WHERE AM.Creature_Type = 'SeaCreature'
                                AND AM.ActiveMonthNum = @CurrentMonth
                                AND Time_Start <= @CurrentHour
                                AND Time_End >= @CurrentHour";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreatureMuseum fish = new SeaCreatureMuseum
                            {
                                SeaCreatureName = reader.GetString(reader.GetOrdinal("SeaCreature_name")),
                                SeaCreatureID = reader.GetInt32(reader.GetOrdinal("SeaCreature_ID")),
                                SeaCreatureLocation = reader.GetString(reader.GetOrdinal("Location")),
                                SeaCreatureDate = reader.GetDateTime(reader.GetOrdinal("DateFound")),
                                SeaCreatureType = "SeaCreature"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }
                return returnThese;
            }
        }
    }
}

