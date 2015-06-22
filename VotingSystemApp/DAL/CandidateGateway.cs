using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VotingSystemApp.Models;

namespace VotingSystemApp.DAL
{
    public class CandidateGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VotingConString"].ConnectionString;
        public int Save(Candidate candidate)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Candidates VALUES('" + candidate.Name + "', '" + candidate.Symbol + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public Candidate GetCandidateBySymbol(string symbol)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Candidates WHERE Symbol = '" + symbol + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Candidate candidate = null;


            while (reader.Read())
            {

                if (candidate == null)
                {
                    candidate = new Candidate();
                }

                candidate.Id = int.Parse(reader["ID"].ToString());
                candidate.Name = reader["Name"].ToString();
                candidate.Symbol = reader["Symbol"].ToString();
            }

            reader.Close();
            connection.Close();

            return candidate;
        }
    }
}