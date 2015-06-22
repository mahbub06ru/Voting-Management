using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VotingSystemApp.Models;

namespace VotingSystemApp.DAL
{
    public class CastVoteGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VotingConString"].ConnectionString;
        public List<Candidate> GetAllSymbols()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Candidates";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Candidate> candidates = new List<Candidate>();

            while (reader.Read())
            {
                Candidate candidate = new Candidate();
                candidate.Id = int.Parse(reader["Id"].ToString());
                candidate.Symbol = reader["Symbol"].ToString();


                candidates.Add(candidate);
            }
            reader.Close();
            connection.Close();

            return candidates;
        }

        public int Save(VoteCast voteCast)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO CastVote VALUES('" + voteCast.VoterId + "', '" + voteCast.CandidateId + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }
    }
}