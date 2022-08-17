using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using EntityLayer.Entities;
using FacadeLayer.Connection;
using System.Data.SqlClient;


namespace FacadeLayer.Dal
{
    public class DalCategory
    {
        public static List<EntityCategory> CategoryList()
        {
            List<EntityCategory> entities = new List<EntityCategory>();
            SqlCommand command = new SqlCommand("Select * From TblCategory", DbConnection.sqlConnection );
            if(command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityCategory ent = new EntityCategory();
                ent.Categoryid = int.Parse(dataReader[0].ToString());
                ent.Categoryname=dataReader[1].ToString();
                entities.Add(ent);
            }
            return entities;
        }


        public static void AddCategory(EntityCategory p)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", p.Categoryname);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }


        public static void DeleteCategory(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCategory Where CategoryID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }


        public static void UpdateCategory(EntityCategory entityCategory)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command=new SqlCommand("Update TblCategory set CategoryName=@p1 where categoryID=@p2", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityCategory.Categoryname);
            command.Parameters.AddWithValue("@p2", entityCategory.Categoryid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

    }
}
