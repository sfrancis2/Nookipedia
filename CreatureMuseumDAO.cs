using System.Data.SqlClient;
using SqlConnection = System.Data.SqlClient.SqlConnection;

namespace Nookipedia
{
    internal class CreatureMuseumDAO
    {
        readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
        public List<CreatureMuseum> GetAll()
        {
            List<CreatureMuseum> returnThese = new List<CreatureMuseum>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Fish_name, Fish_ID, Location, DateFound FROM Fish, FishMuseum WHERE FishID = Fish_ID";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum fish = new CreatureMuseum
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Fish_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Fish_ID")),
                                CreatureLocation = reader.GetString(reader.GetOrdinal("Location")),
                                CreatureDate = reader.GetDateTime(reader.GetOrdinal("DateFound")),
                                CreatureType = "Fish"
                            };
                            returnThese.Add(fish);
                        }
                    }
                }

                query = "SELECT Insect_name, Insect_ID, Location, DateFound FROM Insect, InsectMuseum WHERE InsectID = Insect_ID";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum insect = new CreatureMuseum
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("Insect_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("Insect_ID")),
                                CreatureLocation = reader.GetString(reader.GetOrdinal("Location")),
                                CreatureDate = reader.GetDateTime(reader.GetOrdinal("DateFound")),
                                CreatureType = "Insect"
                            };
                            returnThese.Add(insect);
                        }
                    }
                }

                query = "SELECT SeaCreature_name, SeaCreature_ID, Location, DateFound FROM SeaCreatureMuseum, SeaCreature WHERE SeaCreatureID = SeaCreature_ID";

                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum seaCreatureMuseum = new CreatureMuseum
                            {
                                CreatureName = reader.GetString(reader.GetOrdinal("SeaCreature_name")),
                                CreatureID = reader.GetInt32(reader.GetOrdinal("SeaCreature_ID")),
                                CreatureLocation = reader.GetString(reader.GetOrdinal("Location")),
                                CreatureDate = reader.GetDateTime(reader.GetOrdinal("DateFound")),
                                CreatureType = "SeaCreature"
                            };
                            returnThese.Add(seaCreatureMuseum);
                        }
                    }
                }
            }

            return returnThese;
        }

        public List<CreatureMuseum> GetAllFilter(string? searchbox, int? month)
        {
            List<CreatureMuseum> filterAll = new List<CreatureMuseum>();

            string queryFishMonth = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name 
                                    FROM 
                                        FishMuseum as FM 
                                    JOIN 
                                        Fish AS F ON FM.FishID = Fish_ID
                                    JOIN 
                                        ActiveMonth AS AM ON FM.Fish_ID = AM.Creature_ID
                                    WHERE
                                        AM.Creature_Type = 'Fish'
                                        AND AM.ActiveMonthNum = @Month";

            string queryFishSearch = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name
                                    FROM 
                                        FishMuseum as FM
                                    JOIN Fish AS F ON FM.FishID = F.Fish_ID
                                    WHERE Fish_name LIKE '%' + @SearchPattern + '%'";

            string queryFishBoth = @"SELECT FM.FishID, FM.Location, FM.DateFound, F.Fish_name 
                                    FROM 
                                        FishMuseum as FM 
                                    JOIN 
                                        Fish AS F ON FM.FishID = Fish_ID
                                    JOIN 
                                        ActiveMonth AS AM ON F.Fish_ID = AM.Creature_ID
                                    WHERE Fish_name LIKE '%' + @SearchPattern + '%'
                                    AND AM.Creature_Type = 'Fish'
                                    AND AM.ActiveMonthNum = @Month";



            string queryFishAll = @"SELECT Fish_name, F.Fish_ID, Location, DateFound 
                                FROM FishMuseum
                                JOIN Fish AS F
                                WHERE FishID = F.Fish_ID";

            string querySCMonth = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name 
                        FROM 
                            SeaCreatureMuseum as SC 
                        JOIN 
                            SeaCreature AS F ON SC.SeaCreatureID = SeaCreature_ID
                        JOIN 
                            ActiveMonth AS AM ON F.SeaCreature_ID = AM.Creature_ID
                        WHERE
                            AM.Creature_Type = 'SeaCreature'
                            AND AM.ActiveMonthNum = @Month";

            string querySCSearch = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name
                        FROM 
                            SeaCreatureMuseum as SC
                        JOIN SeaCreature AS F ON SC.SeaCreatureID = F.SeaCreature_ID
                        WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'";

            string querySCBoth = @"SELECT SC.SeaCreatureID, SC.Location, SC.DateFound, F.SeaCreature_name 
                        FROM 
                            SeaCreatureMuseum as SC 
                        JOIN 
                            SeaCreature AS F ON SC.SeaCreatureID = SeaCreature_ID
                        JOIN 
                            ActiveMonth AS AM ON F.SeaCreature_ID = AM.Creature_ID
                        WHERE SeaCreature_name LIKE '%' + @SearchPattern + '%'
                        AND AM.Creature_Type = 'SeaCreature'
                        AND AM.ActiveMonthNum = @Month";


            string querySCAll = "SELECT SeaCreatureMuseum.SeaCreatureID, SeaCreatureMuseum.Location, SeaCreatureMuseum.DateFound, SeaCreature.SeaCreature_name " +
                                "FROM SeaCreatureMuseum JOIN SeaCreature ON SeaCreatureMuseum.SeaCreatureID = SeaCreature.SeaCreature_ID";

            // For Insect
            string queryInsectMonth = @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE
                            AM.Creature_Type = 'Insect'
                            AND AM.ActiveMonthNum = @Month";

            string queryInsectSearch = @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name
                        FROM 
                            InsectMuseum as IM
                        JOIN Insect AS F ON IM.InsectID = F.Insect_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'";

            string queryInsectBoth = @"SELECT IM.InsectID, IM.Location, IM.DateFound, F.Insect_name 
                        FROM 
                            InsectMuseum as IM 
                        JOIN 
                            Insect AS F ON IM.InsectID = Insect_ID
                        JOIN 
                            ActiveMonth AS AM ON F.Insect_ID = AM.Creature_ID
                        WHERE Insect_name LIKE '%' + @SearchPattern + '%'
                        AND AM.Creature_Type = 'Insect'
                        AND AM.ActiveMonthNum = @Month";

            string queryInsectAll = "SELECT InsectMuseum.InsectID, InsectMuseum.Location, InsectMuseum.DateFound, Insect.Insect_name " +
                              "FROM InsectMuseum " +
                              "JOIN Insect ON InsectMuseum.InsectID = Insect.Insect_ID";


            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (month == null && searchbox == null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryFishAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CreatureMuseum fish = new CreatureMuseum
                        {
                            CreatureID = reader.GetInt32(0),
                            CreatureLocation = reader.GetString(1),
                            CreatureDate = reader.GetDateTime(2),
                            CreatureName = reader.GetString(3)
                        };
                        filterAll.Add(fish);
                    }
                }

                sqlCommand = new SqlCommand(querySCAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CreatureMuseum seacreature = new CreatureMuseum
                        {
                            CreatureID = reader.GetInt32(0),
                            CreatureLocation = reader.GetString(1),
                            CreatureDate = reader.GetDateTime(2),
                            CreatureName = reader.GetString(3)
                        };
                        filterAll.Add(seacreature);
                    }
                }

                sqlCommand = new SqlCommand(queryInsectAll, conn);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CreatureMuseum insect = new CreatureMuseum
                        {
                            CreatureID = reader.GetInt32(0),
                            CreatureLocation = reader.GetString(1),
                            CreatureDate = reader.GetDateTime(2),
                            CreatureName = reader.GetString(3)
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
                            CreatureMuseum fish = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (sqlCommand = new SqlCommand(querySCSearch, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum seacreature = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
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
                            CreatureMuseum insect = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
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
                            CreatureMuseum fish = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (sqlCommand = new SqlCommand(querySCMonth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum seacreature = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
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
                            CreatureMuseum insect = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
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
                            CreatureMuseum fish = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
                            };
                            filterAll.Add(fish);
                        }
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand(querySCBoth, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@SearchPattern", searchbox);
                    sqlCommand.Parameters.AddWithValue("@Month", month); // Assuming month is an integer

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CreatureMuseum seacreature = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
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
                            CreatureMuseum insect = new CreatureMuseum
                            {
                                CreatureID = reader.GetInt32(0),
                                CreatureLocation = reader.GetString(1),
                                CreatureDate = reader.GetDateTime(2),
                                CreatureName = reader.GetString(3)
                            };
                            filterAll.Add(insect);
                        }
                    }
                }
                conn.Close();
                return filterAll;
            }

        }

        public void CreateCreature(int ID, string type, string Location, DateTime date)
        {
            string insectQuery = @"
                INSERT INTO [dbo].[InsectMuseum]
                ([InsectID], [MuseumID], [Location], [DateFound])
                VALUES (@ID, @MuseumID, @Location, @DateFound)";

            string seacreatureQuery = @"
                INSERT INTO [dbo].[SeaCreatureMuseum]
                ([SeaCreatureID], [MuseumID], [Location], [DateFound])
                VALUES (@ID, @MuseumID, @Location, @DateFound)";

            string fishQuery = @"
                INSERT INTO [dbo].[FishMuseum]
                ([FishID], [MuseumID], [Location], [DateFound])
                VALUES (@ID, @MuseumID, @Location, @DateFound)";

            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Nookipedia;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = null;
                if (type == "fish")
                    query = fishQuery;
                if (type == "insect")
                    query = insectQuery;
                if (type == "seacreature")
                    query = seacreatureQuery;

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@ID", ID);
                sqlCommand.Parameters.AddWithValue("@MuseumID", 1); // Replace with the actual MuseumID
                sqlCommand.Parameters.AddWithValue("@Location", Location);
                sqlCommand.Parameters.AddWithValue("@DateFound", date);

                sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
