using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VotingSystemApp.Models;

namespace VotingSystemApp.DAL
{
    public class VoterGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VotingConString"].ConnectionString;
        public int Save(Voter voter)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Voters VALUES('" + voter.Name + "', '" + voter.VoterId + "')";
           
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public Voter GetVoterByVoterId(string voterId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Voters WHERE VoterID = '" + voterId + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Voter voter = null;


            while (reader.Read())
            {

                if (voter == null)
                {
                    voter = new Voter();
                }

                voter.Id = int.Parse(reader["ID"].ToString());
                voter.Name = reader["Name"].ToString();
                voter.VoterId = reader["VoterID"].ToString();
            }

            reader.Close();
            connection.Close();

            return voter;
        }
    }
}