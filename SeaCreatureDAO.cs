using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class SeaCreatureDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<SeaCreature> GetAllSeaCreature()
        {
            List<SeaCreature> returnThese = new List<SeaCreature>();

            //connect to Server
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    SeaCreature SeaCreature = new SeaCreature
                    {
                        SeaCreatureName = reader.GetString(0),
                        SeaCreatureID = reader.GetInt32(1),
                        SeaCreatureStart = reader.GetTimeSpan(2),
                        SeaCreatureEnd = reader.GetTimeSpan(3)
                    };
                    returnThese.Add(SeaCreature);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<SeaCreature> FilterSeaCreature(string? searchbox, int? month)
        {
            List<SeaCreature> filterSeaCreatureActive = new List<SeaCreature>();
            string queryMonth =
                  @"SELECT 
                        S.SeaCreature_name,
                        S.SeaCreature_ID,
                        S.Time_Start,
                        S.Time_End
                    FROM 
                        SeaCreature AS S
                    JOIN 
                        ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'SeaCreature'
                        AND AM.ActiveMonthNum = @Month";
            string querySearch = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'";

            string queryBoth = @"SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End 
                               FROM SeaCreature 
                               JOIN 
                                    ActiveMonth AS AM ON SeaCreature_ID = AM.Creature_ID
                               WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%' 
                               AND AM.Creature_Type = 'SeaCreature'
                               AND AM.ActiveMonthNum = @Month";


            string queryAll = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SeaCreature SeaCreature = new SeaCreature
                        {
                            SeaCreatureName = reader.GetString(0),
                            SeaCreatureID = reader.GetInt32(1),
                            SeaCreatureStart = reader.GetTimeSpan(2),
                            SeaCreatureEnd = reader.GetTimeSpan(3)
                        };
                        filterSeaCreatureActive.Add(SeaCreature);
                    }
                }
                conn.Close();
                return filterSeaCreatureActive;
            }
            else if (month == null && searchbox != null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                    conn.Close();
                    return filterSeaCreatureActive;
                }
            }
            else if (searchbox == null && month != null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                    conn.Close();
                    return filterSeaCreatureActive;
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
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                }
                conn.Close();
                return filterSeaCreatureActive;
            }
        }

        public List<SeaCreature> GetAllActiveSeaCreature()
        {
            List<SeaCreature> returnThese = new List<SeaCreature>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT
                                        S.SeaCreature_name,
                                        S.SeaCreature_ID,
                                        S.Time_Start,
                                        S.Time_End
                                    FROM
                                        SeaCreature AS S
                                    JOIN
                                        ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                                    WHERE
                                        AM.Creature_Type = 'SeaCreature'
                                        AND AM.ActiveMonthNum = @CurrentMonth
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour;";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature fish = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(reader.GetOrdinal("SeaCreature_name")),
                                SeaCreatureID = reader.GetInt32(reader.GetOrdinal("SeaCreature_ID")),
                                SeaCreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                SeaCreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                SeaCreatureType = "SeaCreature"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }
                return returnThese;
            }
        }

        public List<SeaCreature> FilterActiveSeaCreature(string? searchbox, int? month)
        {
            List<SeaCreature> filterSeaCreatureActive = new List<SeaCreature>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            string queryMonthActive =
                    @"SELECT 
                        S.SeaCreature_name,
                        S.SeaCreature_ID,
                        S.Time_Start,
                        S.Time_End
                    FROM 
                        SeaCreature AS S
                    JOIN 
                        ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'SeaCreature'
                        AND AM.ActiveMonthNum = @Month

                    INTERSECT

                    SELECT 
                        S.SeaCreature_name,
                        S.SeaCreature_ID,
                        S.Time_Start,
                        S.Time_End
                    FROM 
                        SeaCreature AS S
                    JOIN 
                        ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'SeaCreature'
                        AND AM.ActiveMonthNum = @CurrentMonth

                        -- Check the time
                        AND Time_Start <= @CurrentHour
                        AND Time_End >= @CurrentHour";

            string querySearchActive =
                 @"SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'
                        INTERSECT

                        SELECT 
                                S.SeaCreature_name,
                                S.SeaCreature_ID,
                                S.Time_Start,
                                S.Time_End
                            FROM 
                                SeaCreature AS S
                            JOIN 
                                ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                            WHERE 
                                AM.Creature_Type = 'SeaCreature'
                                AND AM.ActiveMonthNum = @CurrentMonth
                                -- Check the time
                                AND Time_Start <= @CurrentHour
                                AND Time_End >= @CurrentHour";

            string queryBothActive =
                @"SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End 
                               FROM SeaCreature
                               JOIN
                                    ActiveMonth AS AM ON SeaCreature_ID = AM.Creature_ID
                               WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%' 
                               AND AM.Creature_Type = 'SeaCreature'
                               AND AM.ActiveMonthNum = @Month

                                INTERSECT

                                SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End
                                FROM SeaCreature
                                JOIN 
                                    ActiveMonth AS AM ON SeaCreature_ID = AM.Creature_ID
                                WHERE 
                                    AM.Creature_Type = 'SeaCreature'
                                    AND AM.ActiveMonthNum = @CurrentMonth
                                    -- Check the time
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour";


            string queryAllActive = @"SELECT
                                        S.SeaCreature_name,
                                        S.SeaCreature_ID,
                                        S.Time_Start,
                                        S.Time_End
                                    FROM
                                        SeaCreature AS S
                                    JOIN
                                        ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                                    WHERE
                                        AM.Creature_Type = 'SeaCreature'
                                        AND AM.ActiveMonthNum = @CurrentMonth
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour;";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAllActive, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                    while (reader.Read())
                    {
                        SeaCreature SeaCreature = new SeaCreature
                        {
                            SeaCreatureName = reader.GetString(0),
                            SeaCreatureID = reader.GetInt32(1),
                            SeaCreatureStart = reader.GetTimeSpan(2),
                            SeaCreatureEnd = reader.GetTimeSpan(3)
                        };
                        filterSeaCreatureActive.Add(SeaCreature);
                    }
                }
                conn.Close();
                return filterSeaCreatureActive;
            }
            else if (month == null && searchbox != null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySearchActive, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                    conn.Close();
                    return filterSeaCreatureActive;
                }
            }
            else if (searchbox == null && month != null)
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryMonthActive, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                    conn.Close();
                    return filterSeaCreatureActive;
                }
            }
            else
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryBothActive, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeaCreature SeaCreature = new SeaCreature
                            {
                                SeaCreatureName = reader.GetString(0),
                                SeaCreatureID = reader.GetInt32(1),
                                SeaCreatureStart = reader.GetTimeSpan(2),
                                SeaCreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterSeaCreatureActive.Add(SeaCreature);
                        }
                    }
                }
                conn.Close();
                return filterSeaCreatureActive;
            }
        }

    }
}

