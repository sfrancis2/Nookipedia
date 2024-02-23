using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class FishMuseumDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<FishMuseum> GetAllFish()
        {
            List<FishMuseum> returnThese = new List<FishMuseum>();

            //connect to Server
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT FishMuseum.FishID, FishMuseum.Location, FishMuseum.DateFound, Fish.Fish_name FROM FishMuseum JOIN Fish ON FishMuseum.FishID = Fish.Fish_ID ";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    FishMuseum fish = new FishMuseum
                    {
                        FishName = reader.GetString(3),
                        FishID = reader.GetInt32(0),
                        FishLocation = reader.GetString(1),
                        FishDate = reader.GetDateTime(2)
                    };
                    returnThese.Add(fish);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<FishMuseum> FilterFish(string? searchbox, int? month)
        {
            List<FishMuseum> filterFish = new List<FishMuseum>();
            string queryMonth = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name 
                                    FROM 
                                        FishMuseum as FM 
                                    JOIN 
                                        Fish AS F ON FM.FishID = Fish_ID
                                    JOIN 
                                        ActiveMonth AS AM ON FM.Fish_ID = AM.Creature_ID
                                    WHERE
                                        AM.Creature_Type = 'Fish'
                                        AND AM.ActiveMonthNum = @Month";

            string querySearch = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name
                                    FROM 
                                        FishMuseum as FM
                                    JOIN Fish AS F ON FM.FishID = F.Fish_ID
                                    WHERE Fish_name LIKE '%' + @SearchPattern + '%'";

            string queryBoth = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name 
                                    FROM 
                                        FishMuseum as FM 
                                    JOIN 
                                        Fish AS F ON FM.FishID = Fish_ID
                                    JOIN 
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE Fish_name LIKE '%' + @SearchPattern + '%'
                                    AND AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @Month";


            string queryAll = @"SELECT Fish_name, F.Fish_ID, Location, DateFound 
                                FROM FishMuseum
                                JOIN Fish AS F
                                WHERE FishID = F.Fish_ID";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FishMuseum FishMuseum = new FishMuseum
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishLocation = reader.GetString(2),
                            FishDate = reader.GetDateTime(3)
                        };
                        filterFish.Add(FishMuseum);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else if (month == null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", "%" + searchbox + "%");
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FishMuseum FishMuseum = new FishMuseum
                            {
                                FishName = reader.GetString(3),
                                FishID = reader.GetInt32(0),
                                FishLocation = reader.GetString(1),
                                FishDate = reader.GetDateTime(2)
                            };
                            filterFish.Add(FishMuseum);
                        }
                    }
                    conn.Close();
                    return filterFish;
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
                            FishMuseum FishMuseum = new FishMuseum
                            {
                                FishName = reader.GetString(3),
                                FishID = reader.GetInt32(0),
                                FishLocation = reader.GetString(1),
                                FishDate = reader.GetDateTime(2)
                            };
                            filterFish.Add(FishMuseum);
                        }
                    }
                    conn.Close();
                    return filterFish;
                }
            }
            else
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", "%" + searchbox + "%");
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FishMuseum FishMuseum = new FishMuseum
                            {
                                FishName = reader.GetString(3),
                                FishID = reader.GetInt32(0),
                                FishLocation = reader.GetString(1),
                                FishDate = reader.GetDateTime(2)
                            };
                            filterFish.Add(FishMuseum);
                        }
                    }
                }
                conn.Close();
                return filterFish;
            }
        }

        public List<FishMuseum> GetAllActiveFish()
        {
            List<FishMuseum> returnThese = new List<FishMuseum>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name 
                                    FROM 
                                        FishMuseum as FM 
                                    JOIN 
                                        Fish AS F ON FM.FishID = Fish_ID
                                    JOIN 
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE Fish_name LIKE '%' + @SearchPattern + '%'
                                    AND AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @CurrentMonth
                                    AND AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FishMuseum fish = new FishMuseum
                            {
                                FishName = reader.GetString(reader.GetOrdinal("Fish_name")),
                                FishID = reader.GetInt32(reader.GetOrdinal("FishID")),
                                FishLocation = reader.GetString(reader.GetOrdinal("Location")),
                                FishDate = reader.GetDateTime(reader.GetOrdinal("DateFound")),
                                FishType = "FishMuseum"
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

