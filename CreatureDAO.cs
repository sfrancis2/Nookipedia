using System.Data.SqlClient;
using SqlConnection = System.Data.SqlClient.SqlConnection;

namespace Nookipedia
{
    internal class CreatureDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<Creature> GetAll()
        {
            List<Creature> returnThese = new List<Creature>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Fish_name, Fish_ID, Time_Start, Time_End FROM Fish";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Fish_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Fish_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "Fish"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }

                query = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Insect_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Insect_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "Insect"
                            };
                            returnThese.Add(insect);
                        }
                    }
                }

                query = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature seaCreature = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("SeaCreature_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("SeaCreature_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "SeaCreature"
                            };
                            returnThese.Add(seaCreature);
                        }
                    }
                }
            }

            return returnThese;
        }

        public List<Creature> GetAllActive()
        {
            List<Creature> returnThese = new List<Creature>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
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
                                    AND Time_End >= @CurrentHour;";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Fish_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Fish_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "Fish"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }

                query = @"SELECT 
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
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Insect_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Insect_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "Insect"
                            };
                            returnThese.Add(insect);
                        }
                    }
                }

                query = @"SELECT 
                                    S.SeaCreature_name,
                                    S.SeaCreature_ID,
                                    s.Time_Start,
                                    s.Time_End
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
                            Creature seaCreature = new Creature
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("SeaCreature_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("SeaCreature_ID")),
                                CreatureStart = reader.GetTimeSpan(reader.GetOrdinal("Time_Start")),
                                CreatureEnd = reader.GetTimeSpan(reader.GetOrdinal("Time_End")),
                                CreatureType = "SeaCreature"
                            };
                            returnThese.Add(seaCreature);
                        }
                    }
                }
            }

            return returnThese;
        }

        public List<Creature> GetAllFilter(string? searchbox, int? month)
        {
            List<Creature> filterAll = new List<Creature>();

            string queryFishMonth = @"SELECT
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

            string queryFishSearch = @"SELECT Fish_name, Fish_ID, Time_Start, Time_End 
                                FROM Fish 
                                WHERE Fish_name LIKE '%' + @SearchPattern + '%'";

            string queryFishBoth = @"SELECT F.Fish_name, F.Fish_ID, F.Time_Start, F.Time_End 
                                    FROM Fish AS F
                                    JOIN ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE F.Fish_name LIKE '%' + @SearchPattern + '%'
                                    AND AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @Month";


            string queryFishAll = "SELECT Fish_name, Fish_ID, Time_Start, Time_End FROM Fish";

            string querySeaCreatureMonth = @"SELECT
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

            string querySeaCreatureSearch = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'";

            string querySeaCreatureBoth = @"SELECT S.SeaCreature_name, S.SeaCreature_ID, S.Time_Start, S.Time_End 
                                            FROM SeaCreature AS S
                                            JOIN ActiveMonth AS AM ON S.SeaCreature_ID = AM.Creature_ID
                                            WHERE S.SeaCreature_name LIKE '%' + @SearchPattern + '%'
                                            AND AM.Creature_Type = 'SeaCreature'
                                            AND AM.ActiveMonthNum = @Month";


            string querySeaCreatureAll = "SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End FROM SeaCreature";

            string queryInsectMonth = @"SELECT
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

            string queryInsectSearch = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect WHERE Insect_name LIKE '%' + @SearchPattern + '%'";

            string queryInsectBoth = @"SELECT I.Insect_name, I.Insect_ID, I.Time_Start, I.Time_End 
                                       FROM Insect AS I
                                       JOIN ActiveMonth AS AM ON I.Insect_ID = AM.Creature_ID
                                       WHERE I.Insect_name LIKE '%' + @SearchPattern + '%'
                                       AND AM.Creature_Type = 'Insect'
                                       AND AM.ActiveMonthNum = @Month";


            string queryInsectAll = "SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryFishAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Creature fish = new Creature
                        {
                            CreatureName = reader.GetString(0),
                            CreatureID = reader.GetInt32(1),
                            CreatureStart = reader.GetTimeSpan(2),
                            CreatureEnd = reader.GetTimeSpan(3)
                        };
                        filterAll.Add(fish);
                    }
                }

                sqlCommand = new SqlCommand(querySeaCreatureAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Creature seacreature = new Creature
                        {
                            CreatureName = reader.GetString(0),
                            CreatureID = reader.GetInt32(1),
                            CreatureStart = reader.GetTimeSpan(2),
                            CreatureEnd = reader.GetTimeSpan(3)
                        };
                        filterAll.Add(seacreature);
                    }
                }

                sqlCommand = new SqlCommand(queryInsectAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Creature insect = new Creature
                        {
                            CreatureName = reader.GetString(0),
                            CreatureID = reader.GetInt32(1),
                            CreatureStart = reader.GetTimeSpan(2),
                            CreatureEnd = reader.GetTimeSpan(3)
                        };
                        filterAll.Add(insect);
                    }
                }

                conn.Close();
                return filterAll;
            }
            else if (month == null && searchbox != null)
            {
                SqlCommand sqlCommand;
                using (sqlCommand = new SqlCommand(queryFishSearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (sqlCommand = new SqlCommand(querySeaCreatureSearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature seacreature = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(seacreature);
                        }
                    }
                }
                using (sqlCommand = new SqlCommand(queryInsectSearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(insect);
                        }
                    }
                }
                conn.Close();
                return filterAll;
            }
            else if (searchbox == null && month != null)
            {
                SqlCommand sqlCommand;
                using (sqlCommand = new SqlCommand(queryFishMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (sqlCommand = new SqlCommand(querySeaCreatureMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature seacreature = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(seacreature);
                        }
                    }
                }

                using (sqlCommand = new SqlCommand(queryInsectMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(insect);
                        }
                    }
                }
                conn.Close();
                return filterAll;
            }
            else
            {
                using (SqlCommand sqlCommand = new SqlCommand(queryFishBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(querySeaCreatureBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature seacreature = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(seacreature);
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(queryInsectBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAll.Add(insect);
                        }
                    }
                }
                conn.Close();
                return filterAll;
            }

        }

        public List<Creature> GetAllActiveFilter(string? searchbox, int? month)
        {
            List<Creature> filterAllActive = new List<Creature>();
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryFishMonthActive =
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

                string queryFishSearchActive = @"SELECT Fish_name, Fish_ID, Time_Start, Time_End 
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

                string queryFishBothActive =
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


                string queryFishAllActive = @"SELECT 
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
                                        AND Time_End >= @CurrentHour;";

                string querySeaCreatureMonthActive =
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

                string querySeaCreatureSearchActive =
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

                string querySeaCreatureBothActive =
                     @"SELECT SeaCreature_name, SeaCreature_ID, Time_Start, Time_End 
                               FROM SeaCreature 
                               JOIN 
                                   ActiveMonth AS AM ON SeaCreature_ID = AM.Creature_ID
                                   AND AM.Creature_Type = 'SeaCreature'
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
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour";


                string querySeaCreatureAllActive =
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
                                        AND AM.ActiveMonthNum = @CurrentMonth
                                        AND Time_Start <= @CurrentHour
                                        AND Time_End >= @CurrentHour";

                string queryInsectMonthActive =
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

                string queryInsectSearchActive = @"SELECT Insect_name, Insect_ID, Time_Start, Time_End FROM Insect WHERE Insect_name LIKE '%' + @SearchPattern + '%'

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

                string queryInsectBothActive =
                    @"SELECT Insect_name, Insect_ID, Time_Start, Time_End 
                               FROM Insect 
                               JOIN 
                                    ActiveMonth AS AM ON Insect_ID = AM.Creature_ID
                               WHERE 
                               Insect_name LIKE '%' + @SearchPattern + '%' 
                               AND AM.ActiveMonthNum = @Month
                               AND AM.Creature_Type = 'Insect'

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
                                    AND Time_End >= @CurrentHour;";

                string queryInsectAllActive =
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
                                    AND AM.ActiveMonthNum = @CurrentMonth
                                    AND Time_Start <= @CurrentHour
                                    AND Time_End >= @CurrentHour;";

                if (month == null && searchbox == null)
                {
                    SqlCommand sqlCommand = new SqlCommand(queryFishAllActive, conn);
                    sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                    sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature fish = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAllActive.Add(fish);
                        }
                    }

                    sqlCommand = new SqlCommand(querySeaCreatureAllActive, conn);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature seacreature = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAllActive.Add(seacreature);
                        }
                    }

                    sqlCommand = new SqlCommand(queryInsectAllActive, conn);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Creature insect = new Creature
                            {
                                CreatureName = reader.GetString(0),
                                CreatureID = reader.GetInt32(1),
                                CreatureStart = reader.GetTimeSpan(2),
                                CreatureEnd = reader.GetTimeSpan(3)
                            };
                            filterAllActive.Add(insect);
                        }
                    }

                    conn.Close();
                    return filterAllActive;
                }
                else if (month == null && searchbox != null)
                {
                    SqlCommand sqlCommand;
                    using (sqlCommand = new SqlCommand(queryFishSearchActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature fish = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(fish);
                            }
                        }
                    }
                    using (sqlCommand = new SqlCommand(querySeaCreatureSearchActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature seacreature = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(seacreature);
                            }
                        }
                    }
                    using (sqlCommand = new SqlCommand(queryInsectSearchActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature insect = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(insect);
                            }
                        }
                    }
                    conn.Close();
                    return filterAllActive;
                }
                else if (searchbox == null && month != null)
                {
                    SqlCommand sqlCommand;
                    using (sqlCommand = new SqlCommand(queryFishMonthActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature fish = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(fish);
                            }
                        }
                    }
                    using (sqlCommand = new SqlCommand(querySeaCreatureMonthActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature seacreature = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(seacreature);
                            }
                        }
                    }

                    using (sqlCommand = new SqlCommand(queryInsectMonthActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature insect = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(insect);
                            }
                        }
                    }
                    conn.Close();
                    return filterAllActive;
                }
                else
                {
                    using (SqlCommand sqlCommand = new SqlCommand(queryFishBothActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature fish = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(fish);
                            }
                        }
                    }
                    using (SqlCommand sqlCommand = new SqlCommand(querySeaCreatureBothActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature seacreature = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(seacreature);
                            }
                        }
                    }
                    using (SqlCommand sqlCommand = new SqlCommand(queryInsectBothActive, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentMonth);
                        sqlCommand.Parameters.AddWithValue("@CurrentHour", now.TimeOfDay);
                        sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                        sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Creature insect = new Creature
                                {
                                    CreatureName = reader.GetString(0),
                                    CreatureID = reader.GetInt32(1),
                                    CreatureStart = reader.GetTimeSpan(2),
                                    CreatureEnd = reader.GetTimeSpan(3)
                                };
                                filterAllActive.Add(insect);
                            }
                        }
                    }
                    conn.Close();
                    return filterAllActive;
                }
            }
        }
    }
}
