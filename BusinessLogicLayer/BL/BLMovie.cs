using EntityLayer.Entities;
using FacadeLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLMovie
    {
        public static List<EntityMovie> BLMovieList()
        {
            return DalMovie.MovieList();
        }


        public void BLMovieAdd(EntityMovie entityMovie)
        {
            if (entityMovie.MovieCountry != "" && entityMovie.Moviename.Length >=5)
            {
                DalMovie.AddMovie(entityMovie);
            }
            else
            {
                //hata
            }
        }


        public void BLMovieDelete(int id)
        {
            if (id != 0)
            {
                DalMovie.DeleteMovie(id);
            }
            else
            {
                //hata mesajı
            }
        }


        public void BLMovieUpdate(EntityMovie entityMovie)
        {
            if (entityMovie.Moviename != "" && entityMovie.Moviename.Length >= 5 && entityMovie.Movieimage.Length>=15)
            {
                DalMovie.UpdateMovie(entityMovie);
            }
        }

    }
}
