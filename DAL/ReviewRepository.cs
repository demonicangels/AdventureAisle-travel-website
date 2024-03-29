﻿using BusinessLogic;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReviewRepository : IReviewRepository
    {
        private string connection = "Data Source=mssqlstud.fhict.local;User ID=dbi482269_aas2;Password=Ior7dh8Nrr;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Insert(ReviewDTO review)
        {
            string query = "INSERT INTO Reviews (UserId, DestinationId, ReviewTxt, Rating) VALUES (@user, @des, @review, @rate)";
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", review.UserId);
                    cmd.Parameters.AddWithValue("@des", review.DestinationId);
                    cmd.Parameters.AddWithValue("@review", string.IsNullOrEmpty(review.ReviewTxt) ? DBNull.Value : review.ReviewTxt);
			    	cmd.Parameters.AddWithValue("@rate", review.Rating);
			    	cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new BusinessLogic.InvalidInformationException(ex.Message);
            }
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ReviewDTO[] GetReviewsByDesId(int id)
        {
            var query = "SELECT * FROM Reviews WHERE DestinationId = @id ";
            List<ReviewDTO> reviewList = new List<ReviewDTO>();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ReviewDTO r = new ReviewDTO();
                        r.UserId = (int)reader["UserId"];
                        r.DestinationId = (int)reader["DestinationId"];
                        r.ReviewTxt = reader["ReviewTxt"].ToString();
                        r.Rating = Convert.ToDouble(reader["Rating"].ToString());
                        reviewList.Add(r);
                    }
                }
                return reviewList.ToArray();
            }
            catch(Exception ex)
            {
                throw new BusinessLogic.InvalidInformationException(ex.Message);
            }
        }

		public ReviewDTO[] GetReviews()
		{
			var query = "SELECT * FROM Reviews";
			List<ReviewDTO> reviewList = new List<ReviewDTO>();
            try
            {
			    using (SqlConnection con = new SqlConnection(connection))
			    {
			    	con.Open();
			    	SqlCommand cmd = new SqlCommand(query, con);
			    	cmd.ExecuteNonQuery();
			    	SqlDataReader reader = cmd.ExecuteReader();
			    	while (reader.Read())
			    	{
			    		ReviewDTO r = new ReviewDTO();
			    		r.UserId = (int)reader["UserId"];
			    		r.DestinationId = (int)reader["DestinationId"];
			    		r.ReviewTxt = reader["ReviewTxt"].ToString();
			    		r.Rating = Convert.ToDouble(reader["Rating"].ToString());
			    		reviewList.Add(r);
			    	}
			    }
			    return reviewList.ToArray();
            }
            catch (Exception ex)
            {
                throw new FailedToRetrieveInformationException(ex.Message);
            }
		}

        public ReviewDTO UpdateReview(ReviewDTO r)
        {
            var query = "UPDATE Reviews SET ReviewTxt = @re WHERE UserId = @id AND DestinationId = @des";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@re", r.ReviewTxt);
                cmd.Parameters.AddWithValue("@id", r.UserId);
                cmd.Parameters.AddWithValue("@des", r.DestinationId);
                cmd.ExecuteNonQuery();
            }
            return r;
        }
    }
}
