using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class InsectDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<Insect> GetAllInsect()
        {
            List<Insect> returnThese = new List<Insect>();

            //connect to Server
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Insect Insect = new Insect
                    {
                        InsectName = reader.GetString(0),
                        InsectID = reader.GetInt32(1),
                        InsectStart = reader.GetTimeSpan(2),
                        InsectEnd = reader.GetTimeSpan(3)
                    };
                    returnThese.Add(Insect);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<Insect> FilterInsect(string? searchbox, int? month)
        {
            List<Insect> filterInsect = new List<Insect>();
            string queryMonth =
              @"SELECT
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
                   AND AM.ActiveMonthNum = @Month";

            string querySearch = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect WHERE Insect_name LIKE '%' + @SearchPattern + '%'";

            string queryBoth = @"SELECT I.Insect_name, I.Insect_ID, I.Time_Start, I.Time_End 
                                       FROM Insect AS I
                                       JOIN ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                       WHERE I.Insect_name LIKE '%' + @SearchPattern + '%'
                                       AND AM.Creature_Type = 'Insect'
                                       AND AM.ActiveMonthNum = @Month";


            string queryAll = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Insect Insect = new Insect
                        {
                            InsectName = reader.GetString(0),
                            InsectID = reader.GetInt32(1),
                            InsectStart = reader.GetTimeSpan(2),
                            InsectEnd = reader.GetTimeSpan(3)
                        };
                        filterInsect.Add(Insect);
                    }
                }
                conn.Close();
                return filterInsect;
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsect.Add(Insect);
                        }
                    }
                    conn.Close();
                    return filterInsect;
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsect.Add(Insect);
                        }
                    }
                    conn.Close();
                    return filterInsect;
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsect.Add(Insect);
                        }
                    }
                }
                conn.Close();
                return filterInsect;
            }
        }

        public List<Insect> GetAllActiveInsect()
        {
            List<Insect> returnThese = new List<Insect>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
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
                                    AND Time_End >= @CurrentHour;";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Insect fish = new Insect
                            {
                                InsectName = reader.GetString(reader.GetOrdinal("Insect_name")),
                                InsectID = reader.GetInt32(reader.GetOrdinal("Insect_ID")),
                                InsectStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                InsectEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                InsectType = "Insect"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }
                return returnThese;
            }
        }

        public List<Insect> FilterActiveInsect(string? searchbox, int? month)
        {
            List<Insect> filterInsectActive = new List<Insect>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            string queryMonthActive =
                @"SELECT 
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

                        -- Check the time
                        AND Time_Start <= @CurrentHour
                        AND Time_End >= @CurrentHour";

            string querySearchActive =
                @"SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect WHERE Insect_name LIKE '%' + @SearchPattern + '%'

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
                        AND AM.ActiveMonthNum = @Month

                        -- Check the time
                        AND Time_Start <= @CurrentHour
                        AND Time_End >= @CurrentHour";

            string queryBothActive =
                @"SELECT Insect_name, Insect_ID, Time_Start, Time_End 
                               FROM Insect 
                               WHERE Insect_name LIKE '%' + @SearchPattern + '%' 
                               AND Insect_name IN (
                                        SELECT 
                                            I.Insect_name,
                                        FROM 
                                            Insect AS I
                                        JOIN 
                                            ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                        WHERE 
                                            AM.Creature_Type = 'Insect'
                                            AND AM.ActiveMonthNum = @Month)
                                INTERSECT

                                SELECT Insect_name, Insect_ID, Time_Start, Time_End
                                FROM Insect
                                WHERE
                                (
                                    SELECT 
                                        I.Insect_name,
                                        I.Insect_ID,
                                        F.Time_Start,
                                        F.Time_End
                                    FROM 
                                        Insect AS I
                                    JOIN 
                                        ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                    WHERE 
                                        AM.Creature_Type = 'Insect'
                                        AND AM.ActiveMonthNum = @CurrentMonth

                                    -- Check the time
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour
                                )";

            string queryAllActive =
                              @"SELECT Insect_name, Insect_ID, Time_Start, Time_End
                                FROM Insect
                                WHERE
                                (
                                    SELECT 
                                        I.Insect_name,
                                        I.Insect_ID,
                                        F.Time_Start,
                                        F.Time_End
                                    FROM 
                                        Insect AS I
                                    JOIN 
                                        ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                    WHERE 
                                        AM.Creature_Type = 'Insect'
                                        AND AM.ActiveMonthNum = @CurrenMonth

                                    -- Check the time
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour
                                )";

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
                        Insect Insect = new Insect
                        {
                            InsectName = reader.GetString(0),
                            InsectID = reader.GetInt32(1),
                            InsectStart = reader.GetTimeSpan(2),
                            InsectEnd = reader.GetTimeSpan(3)
                        };
                        filterInsectActive.Add(Insect);
                    }
                }
                conn.Close();
                return filterInsectActive;
            }
            else if (month == null)
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsectActive.Add(Insect);
                        }
                    }
                    conn.Close();
                    return filterInsectActive;
                }
            }
            else if (searchbox == null)
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsectActive.Add(Insect);
                        }
                    }
                    conn.Close();
                    return filterInsectActive;
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
                            Insect Insect = new Insect
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectStart = reader.GetTimeSpan(2),
                                InsectEnd = reader.GetTimeSpan(3)
                            };
                            filterInsectActive.Add(Insect);
                        }
                    }
                }
                conn.Close();
                return filterInsectActive;
            }
        }
    }
}

