using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace datingapp
{
    public class sqlclass : Interfaceclass
    {

        public string sqlstring { get; set; }

        public SqlConnection cnn { get; set; } // Data Source=DESKTOP-K766O00\SQLEXPRESS01;Initial Catalog=DatingDB;Integrated Security=True
        public bool isinitiated { get; set; }

        public sqlclass(string mystring)
        {
            sqlstring = mystring;
        }

        public bool conndb()
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqlstring);

                cnn = connection;

                cnn.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatedatabase(string commandtext, Dictionary<string, dynamic> values, string targetcolumn, dynamic targetvalue) // "UPDATE Sales.Store SET Demographics = @demographics " + "WHERE CustomerID = @ID;";
        {

            SqlCommand command = new SqlCommand(commandtext, cnn);

            foreach (var obj in values)
            {
                Type mytype = obj.Value.GetType();

                if (mytype == typeof(int))
                {
                    command.Parameters.Add(obj.Key, SqlDbType.Int);
                    command.Parameters[obj.Key].Value = obj.Value;
                }
                else if (mytype == typeof(string))
                {
                    command.Parameters.Add(obj.Key, SqlDbType.VarChar);
                    command.Parameters[obj.Key].Value = obj.Value;
                }
            }

            // Use AddWithValue to assign Demographics. 
            // SQL Server will implicitly convert strings into XML.
            command.Parameters.AddWithValue(targetcolumn, targetvalue);

            try
            {
                Int32 rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("RowsAffected: {0}", rowsAffected);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool writetodatabase(string commandtext1, string commandtext2, Dictionary<string, dynamic> table1, Dictionary<string, dynamic> table2) // @"insert into table1(value1, value2) values (@key1, @key2); insert into table2(value1, value2) values(@key1, @key2);"
        {

            SqlCommand command = new SqlCommand(commandtext1, cnn);
            try
            {

                foreach (var obj in table1)
                {
                    command.Parameters.AddWithValue(obj.Key, obj.Value);
                }

                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Added successfully table 1");

                    SqlCommand command1 = new SqlCommand(commandtext2, cnn);
                    foreach (var obj in table2)
                    {
                        command1.Parameters.AddWithValue(obj.Key, obj.Value);
                    }

                    string myid = getid("email", table1["@email"]);

                    Console.WriteLine(myid);
                    Console.WriteLine(table1["@email"]);

                    command1.Parameters.AddWithValue("@idaccount", Convert.ToInt32(myid));

                    if (command1.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Added successfully table 2");
                    }
                    }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool deletetable(string idkey, string idvalue, string table) // DELETE FROM table WHere id=@param
        {


            string commandtext = $"DELETE FROM {table} WHere {idkey}=@param";
            SqlCommand command = new SqlCommand(commandtext, cnn);

            command.Parameters.Add("@param", System.Data.SqlDbType.Int);
            command.Parameters["@param"].Value = idvalue;

            int slettet = command.ExecuteNonQuery();
            if (slettet > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkdatabase(string idkey, dynamic idvalue, string checkparam, string column, string table) // SELECT * FROM table where id=@param
        {

            try
            {

                SqlCommand cmd = new SqlCommand($"SELECT {column} FROM {table} where {idkey}=@mycheck", cnn);
                cmd.Parameters.AddWithValue("@mycheck", idvalue);

                string readerresult = cmd.ExecuteScalar()?.ToString();

                if (readerresult == checkparam)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        public bool checkmatch(string user1id, string user2id) // SELECT sendlike, recievelike FROM matches
        {

            try
            {

                SqlCommand cmd = new SqlCommand($"SELECT sendlike, recievelike, mymatch FROM matches", cnn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == user1id && reader.GetString(1) == user2id || reader.GetString(0) == user2id && reader.GetString(1) == user1id)
                    {
                        if (reader.GetString(2) == "0")
                        {
                            reader.Close();
                            return true;
                        }
                    }
                }
                reader.Close();
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool checklike(string user1id, string user2id) // SELECT sendlike, recievelike FROM matches
        {

            try
            {

                SqlCommand cmd = new SqlCommand($"SELECT sendlike, recievelike FROM matches", cnn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == user1id && reader.GetString(1) == user2id || reader.GetString(0) == user2id && reader.GetString(1) == user1id)
                    {
                        reader.Close();
                        return true;
                    }
                }
                reader.Close();
                return false;

            }
            catch
            {
                return false;
            }
        }

        public bool signmatch(string user1id, string user2id) // SELECT sendlike, recievelike FROM matches
        {
            // 0 = true : 1 = false
            try
            {

                SqlCommand cmd = new SqlCommand($"SELECT sendlike, recievelike, mymatch, matchesid FROM matches", cnn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == user1id && reader.GetString(1) == user2id || reader.GetString(0) == user2id && reader.GetString(1) == user1id)
                    {
                        if (reader.GetString(2) == "1")
                        {
                            SqlCommand cmd1 = new SqlCommand($"UPDATE matches SET mymatch = @true Where matchesid = @mymatchid;", cnn);

                            cmd1.Parameters.Add("@true", SqlDbType.NVarChar).Value = "0";
                            cmd1.Parameters.Add("@mymatchid", SqlDbType.Int).Value = reader.GetInt32(3);

                            Console.WriteLine("added values");
                            reader.Close();

                            int slettet = cmd1.ExecuteNonQuery();
                            if (slettet > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                reader.Close();
                return false;

            }
            catch
            {
                return false;
            }
        }

        public string sendlike(string user1id, string user2id, string otherperson) // SELECT matchesid FROM matches where user1=@id
        { // update function
            try
            {

                SqlCommand cmd4 = new SqlCommand($"SELECT sendlike, recievelike, mymatch, matchesid FROM matches", cnn);

                SqlDataReader reader4 = cmd4.ExecuteReader();

                while (reader4.Read())
                {
                    if (reader4.GetString(0) == user1id && reader4.GetString(1) == user2id && otherperson == reader4.GetString(0) || reader4.GetString(0) == user2id && reader4.GetString(1) == user1id && otherperson == reader4.GetString(0))
                    {
                        reader4.Close();
                        return "signmatch";
                    }
                }

                reader4.Close();

                SqlCommand cmd1 = new SqlCommand(@"insert into matches(sendlike, recievelike, mymatch) values (@sendlike, @recievelike, @mymatch);", cnn);

                cmd1.Parameters.AddWithValue("@sendlike", user1id);
                cmd1.Parameters.AddWithValue("@recievelike", user2id);
                cmd1.Parameters.AddWithValue("@mymatch", "1");

                if (cmd1.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("added like to database");
                    return "addedlike";
                } else
                {
                    return "false";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "false";
            }
        }

        public string getid(string idkey, string idvalue) // SELECT * FROM matches where email=@emailparam
        { // update function

            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT accountid FROM account WHERE {idkey}=@myid", cnn);
                cmd.Parameters.AddWithValue("@myid", idvalue);

                string myid = cmd.ExecuteScalar()?.ToString();

                Console.WriteLine($"this is my id: {myid}");

                return myid;

            } catch
            {
                return "false";
            }
        }

        public bool checkinitiate()
        {
            if (isinitiated)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public dynamic getperson(string idkey, string idvalue) // SELECT * FROM matches where email=@emailparam
        { // update function

            Dictionary<string, dynamic> mydict = new Dictionary<string, dynamic>();
            string myid = "0";
            try
            {

                SqlCommand cmd = new SqlCommand($"SELECT * FROM account WHERE {idkey}=@myid", cnn);
                cmd.Parameters.AddWithValue("@myid", idvalue);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mydict.Add("email", reader["email"].ToString());
                        mydict.Add("passwords", reader["passwords"].ToString());
                        myid = reader["accountid"].ToString();
                        reader.Close();
                    }
                }

                SqlCommand cmd2 = new SqlCommand($"SELECT * FROM profil WHERE idaccount=@thisid", cnn);
                cmd2.Parameters.AddWithValue("@thisid", myid);

                using (SqlDataReader reader1 = cmd2.ExecuteReader())
                {
                    Console.WriteLine($"this is my emial: {"sasad"}");
                    if (reader1.Read())
                    {
                        mydict.Add("alias", reader1["alias"].ToString());
                        mydict.Add("birthsday", reader1["birthsday"].ToString());
                        mydict.Add("køn", reader1["køn"].ToString());
                        mydict.Add("hårfarve", reader1["hårfarve"].ToString());
                        mydict.Add("øjefarve", reader1["øjefarve"].ToString());
                        mydict.Add("matchhårfarve", reader1["matchhårfarve"].ToString());
                        mydict.Add("matchøjefarve", reader1["matchøjefarve"].ToString());
                        mydict.Add("postnummer", reader1["postnummer"].ToString());
                        mydict.Add("bydel", reader1["bydel"].ToString());
                        reader1.Close();
                    }
                }
                Console.WriteLine(mydict);
                return mydict;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
