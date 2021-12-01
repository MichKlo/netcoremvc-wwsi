using FilmDB_MK.Contexts;
using FilmDB_MK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB_MK.Repository
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            
            using (var context = new FilmContext())
            {
                context.Films.Add(filmModel);
                filmModel.ID = 0;
                context.SaveChanges();
            }
            
            return this;
        }
       

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var films=context.Films.Single(FilmModel => FilmModel.ID == id);
                context.Remove(films);
                context.SaveChanges();
            }

            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Update(filmModel);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            
            using (var context = new FilmContext())
            {
                var films = context.Films.Single(FilmModel => FilmModel.ID == id);
                if (newTitle == null)
                    films.Title = "Brak Tytułu";
                else
                    films.Title = newTitle;
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var films = context.Films.SingleOrDefault(FilmModel => FilmModel.ID == id);

            }

                return null;
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                var films = context.Films.ToList();

            }
            return null;
        }
    }
}
