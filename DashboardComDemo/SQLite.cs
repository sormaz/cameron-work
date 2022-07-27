using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace DashboardComDemo
{
    public class SQLite
    {
        public string X;
        public string Y;
        public string Z;
        public string Rx;
        public string Ry;
        public string Rz;

        private string connectionString = "Data Source = DashDemo.db";

        //public void Insert_TCP_Updated_Position()
        //{
        //    //string answer = "Database is empty";

        //    using (var connection = new SqliteConnection(connectionString))
        //    {
        //        if (X != null || Y != null || Z != null || Rx != null || Ry != null || Rz != null)
        //        {
        //            connection.Open();
        //            var command = connection.CreateCommand();
        //            command.CommandText = @"UPDATE robotTCPPosition SET(X,Y,Z,Rx,Ry,Rz)=($X,$Y,$Z,$Rx,$Ry,$Rz)";
        //            command.Parameters.AddWithValue("$X", X);
        //            command.Parameters.AddWithValue("$Y", Y);
        //            command.Parameters.AddWithValue("$Z", Z);
        //            command.Parameters.AddWithValue("$Rx", Rx);
        //            command.Parameters.AddWithValue("$Ry", Ry);
        //            command.Parameters.AddWithValue("$Rz", Rz);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        //public string[] Get_TCP_Position()
        //{
        //    string[] answer = new string[5];
        //    using (var connection = new SqliteConnection(connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = @"SELECT * FROM robotTCPPosition";
        //        using (var reader = command.ExecuteReader())
        //        {
        //            int i = 0;
        //            while (reader.Read())
        //            {
        //                answer[i] = reader.GetString(i);
        //                i++;
        //            }
        //            return answer;
        //        }
        //    }
        //}

        public string InsertNewPose(string moveType, string position, string parameters, string name)
        {
            string answer = "Database is empty";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO robotPoses (moveType,position,parameters,name) VALUES($moveType,$position,$parameters,$name)";

                command.Parameters.AddWithValue("$moveType", moveType);
                command.Parameters.AddWithValue("$position", position);
                command.Parameters.AddWithValue("$parameters", parameters);
                command.Parameters.AddWithValue("$name", name);

                //command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    //int i = 0;
                    while (reader.Read())
                    {
                        answer = reader.GetString(0);
                        //i++;
                        //return answer;                        
                    }

                }
                return answer;
            }
        }

        //The 4 method below are used to format the URscript command
        //By using the selected name from the listbox
        public string GetURScriptCommand(string name)
        {
            //Formats all returned strings to fit URScript understanding
            return GetMoveType(name) + "(" + GetPosition(name) + "," + GetParameters(name) + ")";
        }
        private string GetParameters(string name)
        {
            string answer = "Database is empty";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT parameters FROM robotPoses WHERE name = $name;"; //@"INSERT INTO robotPoses (moveType,position,parameters,name) VALUES('movej','p[.282,-.221,.297,1.5,2.496,-0.06]','a=3,v=0.75,t=0,r=0','Move J 1')";
                command.Parameters.AddWithValue("$name", name);

                //command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answer = reader.GetString(0);
                    }
                }
                return answer;
            }
        }
        private string GetPosition(string name)
        {
            string answer = "Database is empty";
            //Manually installed sqlitedll
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT position FROM robotPoses WHERE name = $name;"; //@"INSERT INTO robotPoses (moveType,position,parameters,name) VALUES('movej','p[.282,-.221,.297,1.5,2.496,-0.06]','a=3,v=0.75,t=0,r=0','Move J 1')";
                command.Parameters.AddWithValue("$name", name);

                //command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answer = reader.GetString(0);

                    }

                }
                return answer;
            }
        }
        private string GetMoveType(string name)
        {
            string answer = "Database is empty";
            //Manually installed sqlitedll
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT moveType FROM robotPoses WHERE name = $name;"; //@"INSERT INTO robotPoses (moveType,position,parameters,name) VALUES('movej','p[.282,-.221,.297,1.5,2.496,-0.06]','a=3,v=0.75,t=0,r=0','Move J 1')";
                command.Parameters.AddWithValue("$name", name);
                //command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answer = reader.GetString(0);
                    }
                }
                return answer;
            }
        }

        //Used to get the move primary key names from the sqlite database
        public string[] GetMoveName()
        {
            string[] answer = new string[100000];//Max is 100000 move positions at the moment

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT name FROM robotPoses;"; //@"INSERT INTO robotPoses (moveType,position,parameters,name) VALUES('movej','p[.282,-.221,.297,1.5,2.496,-0.06]','a=3,v=0.75,t=0,r=0','Move J 1')";

                //command.Parameters.AddWithValue("$id", id);

                //command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        answer[i] = reader.GetString(0);
                        i++;
                    }

                    return answer;

                }
                //return null;
            }
        }
    }
}
