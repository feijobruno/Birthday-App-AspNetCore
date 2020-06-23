using BirthdayApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BirthdayApp.Repository
{
    public class PeopleRepository
    {
        private string ConnectionString { get; set; }
        public PeopleRepository(IConfiguration configuration)
        {
            this.ConnectionString = configuration.GetConnectionString("PeopleConnection");
        }

        public void Save(People people)
        {
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                var sql = @" INSERT INTO TB_PEOPLE(Id, FirstName, LastName, Birthday)
                             VALUES (@P1, @P2, @P3, @P4)
                ";

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("P1", people.Id);
                sqlCommand.Parameters.AddWithValue("P2", people.FirstName);
                sqlCommand.Parameters.AddWithValue("P3", people.LastName);
                sqlCommand.Parameters.AddWithValue("P4", people.Birthday);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(People people)
        {
            using (var connection = new SqlConnection(this.ConnectionString))
            {

                var sql = @" UPDATE TB_PEOPLE 
                             SET FirstName = @P2,
                             LastName = @P3,
                             Birthday = @P4
                             WHERE Id = @P1 
                ";

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("P1", people.Id);
                sqlCommand.Parameters.AddWithValue("P2", people.FirstName);
                sqlCommand.Parameters.AddWithValue("P3", people.LastName);
                sqlCommand.Parameters.AddWithValue("P4", people.Birthday);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                var sql = @" DELETE FROM TB_PEOPLE
                             WHERE Id = @P1 
                ";

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("P1", id);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<People> GetAll()
        {
            List<People> result = new List<People>();
            using (var connection = new SqlConnection(this.ConnectionString))
            {

                var sql = @" SELECT Id, FirstName, LastName, Birthday FROM TB_PEOPLE";
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    People people = new People()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Birthday = Convert.ToDateTime(reader["Birthday"])
                    };
                    result.Add(people);
                    //result.OrderBy(people => people.NextBirthday());
                }
                connection.Close();
            }
            return result;
        }


        public People GetById(Guid id)
        {
            List<People> result = new List<People>();

            using (var connection = new SqlConnection(this.ConnectionString))
            {

                var sql = @" SELECT Id, FirstName, LastName, Birthday 
                             FROM TB_PEOPLE
                             WHERE Id = @P1
                ";

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("P1", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    People people = new People()
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Birthday = Convert.ToDateTime(reader["Birthday"])
                    };
                    result.Add(people);
                }
                connection.Close();
            }
            return result.FirstOrDefault();
        }

        public List<People> SearchPeople(string query)
        {
            List<People> result = new List<People>();
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                var sql = $"SELECT * FROM TB_PEOPLE WHERE FirstName LIKE @P1 OR LastName LIKE @P2";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Parameters.AddWithValue("P1", '%' + query + '%');
                sqlCommand.Parameters.AddWithValue("P2", '%' + query + '%');
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    People people = new People()
                    {
                        Id = reader.GetGuid("Id"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("LastName"),
                        Birthday = reader.GetDateTime("Birthday"),
                    };
                    result.Add(people);
                }
                connection.Close();
            }
            return result;
        }
    }
}
