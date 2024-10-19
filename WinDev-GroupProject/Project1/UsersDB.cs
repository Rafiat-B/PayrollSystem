using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project1
{
    public class UsersDB
    {
        //private static readonly List<User> usersDB = new List<User>();

        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

        //Add User to DB if not present already else return false
        public bool AddUser(User user)
        {
            /* using (OracleConnection connection = new OracleConnection(connectionString))
             {
                 connection.Open();
                 using (OracleCommand command = new OracleCommand("INSERT INTO Users (UserId, EmpId, Name, Password, Email, Phone, Dobirth, Address, IsAdmin) VALUES (:UserId, :EmpId, :Name, :Password, :Email, :Phone, :Dobirth, :Address, :IsAdmin)", connection))
                 {
                     command.Parameters.Add(new OracleParameter("UserId", user.UserId));
                     command.Parameters.Add(new OracleParameter("EmpId", user.EmpId));
                     command.Parameters.Add(new OracleParameter("Name", user.Name));
                     command.Parameters.Add(new OracleParameter("Password", user.Password));
                     command.Parameters.Add(new OracleParameter("Email", user.Email));
                     command.Parameters.Add(new OracleParameter("Phone", user.Phone));
                     command.Parameters.Add(new OracleParameter("Dobirth", user.Dobirth));
                     command.Parameters.Add(new OracleParameter("Address", user.Address));
                     command.Parameters.Add(new OracleParameter("IsAdmin", user.IsAdmin ? '1' : '0'));

                     int result = command.ExecuteNonQuery();
                     return result > 0;
                 }
             }*/

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("INSERT INTO Users (UserId, EmpId, Name, Password, Email, Phone, Dobirth, Address, IsAdmin) VALUES (:UserId, :EmpId, :Name, :Password, :Email, :Phone, :Dobirth, :Address, :IsAdmin)", connection))
                    {
                        // Add parameters as before...
                        command.Parameters.Add(new OracleParameter("UserId", user.UserId));
                        command.Parameters.Add(new OracleParameter("EmpId", user.EmpId));
                        command.Parameters.Add(new OracleParameter("Name", user.Name));
                        command.Parameters.Add(new OracleParameter("Password", user.Password));
                        command.Parameters.Add(new OracleParameter("Email", user.Email));
                        command.Parameters.Add(new OracleParameter("Phone", user.Phone));
                        command.Parameters.Add(new OracleParameter("Dobirth", user.Dobirth));
                        command.Parameters.Add(new OracleParameter("Address", user.Address));
                        command.Parameters.Add(new OracleParameter("IsAdmin", user.IsAdmin ? '1' : '0'));

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(string userId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("DELETE FROM Users WHERE UserId = :UserId", connection))
                {
                    command.Parameters.Add(new OracleParameter("UserId", userId));

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool ContainsUser(string userId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM Users WHERE UserId = :UserId", connection))
                {
                    command.Parameters.Add(new OracleParameter("UserId", userId));
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
        }

        //Get user by user Id
        public User GetUser(string userId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("SELECT * FROM Users WHERE UserId = :UserId", connection))
                {
                    command.Parameters.Add(new OracleParameter("UserId", userId));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            long empId = reader["EmpId"] == DBNull.Value ? 0 : Convert.ToInt64(reader["EmpId"]);
                            DateTime dobirth = reader["Dobirth"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Dobirth"]);
                            bool isAdmin = reader["IsAdmin"].ToString() == "1";

                            return new User(
                                reader["UserId"].ToString(),
                                empId,
                                reader["Name"].ToString(),
                                reader["Password"].ToString(),
                                reader["Email"].ToString(),
                                reader["Phone"].ToString(),
                                dobirth,
                                reader["Address"].ToString(),
                                isAdmin
                            );
                        }
                    }
                }
            }
            return null;
        }
        // check if user acc exists for this empId
        public bool UserAccExistsForEmp(long empId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM Users WHERE EmpId = :EmpId", connection))
                {
                    command.Parameters.Add(new OracleParameter("EmpId", empId));
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
        }
    }
}
