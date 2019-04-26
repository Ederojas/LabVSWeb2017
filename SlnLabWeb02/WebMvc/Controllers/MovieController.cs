using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMvc.Data;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class MovieController : Controller
    {
        MovieDbContext db = new MovieDbContext();

        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            //var movies = new List<Movie>();
            //movies.Add(new Movie { MovieId = 1, Title = "Advengers 1", Genre = "Acción", Price = 100, Rating = "5", ReleaseDate = new DateTime(2019, 4, 25) });
            //movies.Add(new Movie { MovieId = 2, Title = "Advengers 2", Genre = "Acción", Price = 100, Rating = "5", ReleaseDate = new DateTime(2019, 4, 25) });
            //movies.Add(new Movie { MovieId = 3, Title = "Advengers 3", Genre = "Acción", Price = 100, Rating = "5", ReleaseDate = new DateTime(2019, 4, 25) });
            //movies.Add(new Movie { MovieId = 4, Title = "Advengers 4", Genre = "Acción", Price = 100, Rating = "5", ReleaseDate = new DateTime(2019, 4, 25) });

            return View(movies);
        }

        //GET: movie/create
        public ActionResult Create()
        {


            return View();
        }
        
        //POST: movie/create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if(ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                //var titulo = movie.Title;
                //Guardar en db
                return RedirectToAction("Index");
                //return RedirectToAction("Index", "Home");//Ir al Home
            }
            return View(movie);
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //POST: movie/edit
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                //var titulo = movie.Title;
                //Guardar en db
                return RedirectToAction("Index");
                //return RedirectToAction("Index", "Home");//Ir al Home
            }
            return View(movie);
        }



        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}