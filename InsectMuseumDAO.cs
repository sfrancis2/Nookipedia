using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace Nookipedia
{
    internal class InsectMuseumDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<InsectMuseum> GetAllInsect()
        {
            List<InsectMuseum> returnThese = new List<InsectMuseum>();

            //connect to Server
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT InsectMuseum.InsectID, InsectMuseum.Location, InsectMuseum.DateFound, Insect.Insect_name FROM InsectMuseum JOIN Insect ON InsectMuseum.InsectID = Insect.Insect_ID ";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    InsectMuseum insect = new InsectMuseum
                    {
                        InsectName = reader.GetString(3),
                        InsectID = reader.GetInt32(0),
                        InsectLocation = reader.GetString(1),
                        InsectDate = reader.GetDateTime(2)
                    };
                    returnThese.Add(insect);
                }
            }
            conn.Close();
            return returnThese;
        }

        public List<InsectMuseum> FilterInsect(string? searchbox, int? month)
        {
            List<InsectMuseum> filterInsect = new List<InsectMuseum>();
            string queryMonth =
                      @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE
                            AM.Creature_Type = 'Insect'
                            AND AM.ActiveMonthNum = @Month";

            string querySearch =
                      @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name
                        FROM 
                            InsectMuseum as IM
                        JOIN Insect AS F ON IM.InsectID = F.Insect_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'";
            string queryBoth =
                @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'
                        AND AM.Creature_Type = 'Insect'
                        AND AM.ActiveMonthNum = @Month";


            string queryAll =
                              "SELECT InsectMuseum.InsectID, InsectMuseum.Location, InsectMuseum.DateFound, Insect.Insect_name " +
                              "FROM InsectMuseum " +
                              "JOIN Insect ON InsectMuseum.InsectID = Insect.Insect_ID";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InsectMuseum InsectMuseum = new InsectMuseum
                        {
                            InsectName = reader.GetString(0),
                            InsectID = reader.GetInt32(1),
                            InsectLocation = reader.GetString(2),
                            InsectDate = reader.GetDateTime(3)
                        };
                        filterInsect.Add(InsectMuseum);
                    }
                }
                conn.Close();
                return filterInsect;
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
                            InsectMuseum InsectMuseum = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(InsectMuseum);
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
                            InsectMuseum InsectMuseum = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(InsectMuseum);
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
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", "%" + searchbox + "%");
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InsectMuseum InsectMuseum = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(InsectMuseum);
                        }
                    }
                }
                conn.Close();
                return filterInsect;
            }
        }

        public List<InsectMuseum> GetAllActiveInsect(string? searchbox, int? month)
        {
            List<InsectMuseum> filterInsect = new List<InsectMuseum>();
            // For Insect
            string queryMonth =
                @"SELECT 
                        IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                    FROM 
                        InsectMuseum AS IM 
                    JOIN 
                        Insect AS F ON F.InsectID = IM.Insect_ID
                    JOIN 
                        ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'Insect'
                        AND AM.ActiveMonthNum = @Month

                    INTERSECT
                    SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE
                            AM.Creature_Type = 'Insect'
                            AND AM.ActiveMonthNum = @CurrentMonth
                            AND Time_Start <= @CurrentHour
                            AND Time_End >= @CurrentHour";

            string querySearch = @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name
                        FROM 
                            InsectMuseum as IM
                        JOIN Insect AS F ON IM.InsectID = F.Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'
                              AND Time_Start <= @CurrentHour
                              AND Time_End >= @CurrentHour";

            string queryBoth =
                    @"SELECT 
                        IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                    FROM 
                        InsectMuseum AS IM 
                    JOIN 
                        Insect AS F ON F.InsectID = IM.Insect_ID
                    JOIN 
                        ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                    WHERE 
                        AM.Creature_Type = 'Insect'
                        AND AM.ActiveMonthNum = @Month
                    INTERSECT
                    SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'
                        AND AM.Creature_Type = 'Insect'
                        AND AM.ActiveMonthNum = @CurrentMonth
                        AND Time_Start <= @CurrentHour
                        AND Time_End >= @CurrentHour";

            string queryAll = @"SELECT InsectMuseum.InsectID, InsectMuseum.Location, InsectMuseum.DateFound, Insect.Insect_name
                              FROM InsectMuseum
                              JOIN Insect ON InsectMuseum.InsectID = Insect.Insect_ID
                              JOIN 
                                  ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                              WHERE AM.ActiveMonthNum = @CurrentMonth
                                  AND Time_Start <= @CurrentHour
                                  AND Time_End >= @CurrentHour";


            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InsectMuseum insect = new InsectMuseum
                        {
                            InsectName = reader.GetString(0),
                            InsectID = reader.GetInt32(1),
                            InsectLocation = reader.GetString(2),
                            InsectDate = reader.GetDateTime(3)
                        };
                        filterInsect.Add(insect);
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
                            InsectMuseum insect = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(insect);
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
                            InsectMuseum insect = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(insect);
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
                            InsectMuseum insect = new InsectMuseum
                            {
                                InsectName = reader.GetString(0),
                                InsectID = reader.GetInt32(1),
                                InsectLocation = reader.GetString(2),
                                InsectDate = reader.GetDateTime(3)
                            };
                            filterInsect.Add(insect);
                        }
                    }
                }
                conn.Close();
                return filterInsect;
            }
        }
    }
}

