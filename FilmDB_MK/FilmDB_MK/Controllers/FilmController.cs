using FilmDB_MK.Models;
using FilmDB_MK.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB_MK.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            FilmModel FilmModel = new FilmModel();
            FilmModel.ID = 1;
            FilmModel.Title = "Zemsta";
            FilmModel.Year = 2002;


            FilmManager FilmManager = new FilmManager();
            FilmManager.AddFilm(FilmModel);
            FilmManager.RemoveFilm(1);
            FilmManager.UpdateFilm(FilmModel);
            FilmManager.ChangeTitle(3, "COŚ");
            FilmManager.GetFilm(2);
            FilmManager.GetFilms();

            return View(FilmManager);
        }
        public IActionResult Add()
        {
            
            return View();
        }
    }
}
