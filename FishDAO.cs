using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class FishDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<Fish> GetAllFish()
        {
            List<Fish> returnThese = new();

            //connect to Server
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT Fish_name, Fish_ID, Time_Start, Time_End FROM Fish";
            SqlCommand sqlCommand = new(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Fish fish = new()
                    {
                        FishName = reader.GetString(0),
                        FishID = reader.GetInt32(1),
                        FishStart = reader.GetTimeSpan(2),
                        FishEnd = reader.GetTimeSpan(3)
                    };
                    returnThese.Add(fish);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<Fish> FilterFish(string? searchbox, int? month)
        {
            List<Fish> filterFish = new();
            string queryMonth = @"SELECT
                                        F.Fish_name,
                                        F.Fish_ID,
                                        F.Time_Start,
                                        F.Time_End
                                    FROM
                                        Fish AS F
                                    JOIN
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE
                                        AM.Creature_Type = 'Fish'
                                        AND AM.ActiveMonthNum = @Month";

            string querySearch = @"SELECT Fish_name, Fish_ID, Time_Start, Time_End 
                                FROM Fish 
                                WHERE Fish_name LIKE '%' + @SearchPattern + '%'";

            string queryBoth = @"SELECT F.Fish_name, F.Fish_ID, F.Time_Start, F.Time_End 
                                    FROM Fish AS F
                                    JOIN ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE F.Fish_name LIKE '%' + @SearchPattern + '%'
                                    AND AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @Month";


            string queryAll = "SELECT Fish_name, Fish_ID, Time_Start, Time_End FROM Fish";

            SqlConnection conn = new(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else if (month == null && searchbox != null)
            {
                using SqlCommand sqlCommand = new(querySearch, conn);
                sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else if (searchbox == null && month != null)
            {
                using SqlCommand sqlCommand = new(queryMonth, conn);
                sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else
            {
                using (SqlCommand sqlCommand = new(queryBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
        }

        public List<Fish> GetAllActiveFish()
        {
            List<Fish> returnThese = new();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = @"SELECT 
                                        F.Fish_name,
                                        F.Fish_ID,
                                        F.Time_Start,
                                        F.Time_End
                                    FROM 
                                        Fish AS F
                                    JOIN 
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE 
                                        AM.Creature_Type = 'Fish'
                                        AND AM.ActiveMonthNum = @CurrentMonth
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour";

            using (SqlCommand sqlCommand = new(query, conn))
            {
                sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                using SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Fish fish = new()
                    {
                        FishName = reader.GetString(reader.GetOrdinal("Fish_name")),
                        FishID = reader.GetInt32(reader.GetOrdinal("Fish_ID")),
                        FishStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                        FishEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                        FishType = "Fish"
                    };
                    returnThese.Add(fish);
                }
            }
            return returnThese;
        }

        public List<Fish> FilterActiveFish(string? searchbox, int? month)
        {
            List<Fish> filterFish = new();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            string queryMonthActive =
                @"SELECT 
                        F.Fish_name,
                        F.Fish_ID,
                        F.Time_Start,
                        F.Time_End
                    FROM 
                        Fish AS F
                    JOIN 
                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'Fish'
                        AND AM.ActiveMonthNum = @Month

                 INTERSECT

                                   SELECT 
                        F.Fish_name,
                        F.Fish_ID,
                        F.Time_Start,
                        F.Time_End
                    FROM 
                        Fish AS F
                    JOIN 
                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'Fish'
                        AND AM.ActiveMonthNum = @CurrentMonth

                        -- Check the time
                        AND Time_Start <= @CurrentHour
                        AND Time_End >= @CurrentHour";

            string querySearchActive =
                              @"SELECT Fish_name, Fish_ID, Time_Start, Time_End 
                                FROM Fish 
                                WHERE Fish_name LIKE '%' + @SearchPattern + '%'

                INTERSECT

                                
                                SELECT 
                                    F.Fish_name,
                                    F.Fish_ID,
                                    F.Time_Start,
                                    F.Time_End
                                FROM 
                                    Fish AS F
                                JOIN 
                                    ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                WHERE 
                                    AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @CurrentMonth

                                    -- Check the time
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour";

            string queryBothActive =
                             @"SELECT Fish_name, Fish_ID, Time_Start, Time_End 
                               FROM Fish 
                               JOIN 
                                    ActiveMonth AS AM ON Fish_ID = AM.Creature_ID
                               WHERE Fish_name LIKE '%' + @SearchPattern + '%' 
                               AND AM.Creature_Type = 'Fish'
                               AND AM.ActiveMonthNum = @Month

                    INTERSECT

                                SELECT 
                                    I.Insect_name,
                                    I.Insect_ID,
                                    I.Time_Start,
                                    I.Time_End
                                FROM 
                                    Insect AS I
                                JOIN 
                                    ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                WHERE 
                                    AM.Creature_Type = 'Insect'
                                    AND AM.ActiveMonthNum = @CurrentMonth
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour";


            string queryAllActive = @"SELECT 
                                        F.Fish_name,
                                        F.Fish_ID,
                                        F.Time_Start,
                                        F.Time_End
                                    FROM 
                                        Fish AS F
                                    JOIN 
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE 
                                        AM.Creature_Type = 'Fish'
                                        AND AM.ActiveMonthNum = @CurrentMonth
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour";

            SqlConnection conn = new(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new(queryAllActive, conn);
                sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else if (month == null && searchbox != null)
            {
                using SqlCommand sqlCommand = new(querySearchActive, conn);
                sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else if (searchbox == null && month != null)
            {
                using SqlCommand sqlCommand = new(queryMonthActive, conn);
                sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
            else
            {
                using (SqlCommand sqlCommand = new(queryBothActive, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Fish Fish = new()
                        {
                            FishName = reader.GetString(0),
                            FishID = reader.GetInt32(1),
                            FishStart = reader.GetTimeSpan(2),
                            FishEnd = reader.GetTimeSpan(3)
                        };
                        filterFish.Add(Fish);
                    }
                }
                conn.Close();
                return filterFish;
            }
        }
    }
}

