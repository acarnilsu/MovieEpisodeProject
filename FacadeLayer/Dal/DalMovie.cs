using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using EntityLayer.Entities;
using FacadeLayer.Connection;
using System.Data.SqlClient;
using System.Data;

namespace FacadeLayer.Dal
{
    public class DalMovie
    {
        public static List<EntityMovie> MovieList()
        {
            List<EntityMovie> values = new List<EntityMovie>();
            SqlCommand command = new SqlCommand("Select * From TblMovies", DbConnection.sqlConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityMovie entityMovie = new EntityMovie();
                entityMovie.Movieid = int.Parse(dataReader["MovieID"].ToString());
                entityMovie.Moviename = dataReader["MovieName"].ToString();
                entityMovie.Moviedirector = dataReader["MovieDirector"].ToString();
                entityMovie.Moviecountry = dataReader["MovieCountry"].ToString();
                entityMovie.Movieimage = dataReader["MovieImage"].ToString();
                entityMovie.Imdb = dataReader["MovieImbdb"].ToString();
                entityMovie.Categoryid = int.Parse(dataReader["CategoryID"].ToString());
                values.Add(entityMovie);
            }
            return values;
        }


        public static void AddMovie(EntityMovie entityMovie)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblMovies (MovieName,MovieDirector,MovieCountry,MovieImdb,CategoryID) values (@p1,@p2,@p3,@p4,@p5)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityMovie.Moviename);
            command.Parameters.AddWithValue("@p2", entityMovie.Moviedirector);
            command.Parameters.AddWithValue("@p3", entityMovie.Moviecountry);
            command.Parameters.AddWithValue("@p4", entityMovie.Imdb);
            command.Parameters.AddWithValue("@p5", entityMovie.Categoryid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }


        public static void DeleteMovie(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblMovies Where MovieID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }


        public static void UpdateMovie(EntityMovie entityMovie)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblMovies set MovieName=@p1, MovieDirector=@p2, MovieCountry=@p3, MovieImage=@p4, MovieIMDB=@p5 where MovieID=@p6", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityMovie.Moviename);
            command.Parameters.AddWithValue("@p2", entityMovie.Moviedirector);
            command.Parameters.AddWithValue("@p3", entityMovie.Moviecountry);
            command.Parameters.AddWithValue("@p4", entityMovie.Imdb);
            command.Parameters.AddWithValue("@p5", entityMovie.Categoryid);
            command.Parameters.AddWithValue("@p6", entityMovie.Movieid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

    }
}
