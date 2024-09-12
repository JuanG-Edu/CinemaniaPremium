using Eva_E1_DesSisWebBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eva_E1_DesSisWebBD.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Index()
        {
            //return View();
            var Peliculillas = from a in RecuperarPeliculas()
                               orderby a.idPelicula
                               select a;
            return View(Peliculillas);
        }

        // GET: Peliculas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peliculas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public List<Peliculas> RecuperarPeliculas()
        {
            return new List<Peliculas>
            {
                new Peliculas
                {
                    idPelicula = 943,
                    nombrePelicula = "El Padrino",
                    numeroSala = 1,
                    horario = "15:00",
                    urlPelicula = "https://th.bing.com/th/id/OIP.ZkJXLF-c-7_qHrNP2pxbmQAAAA?rs=1&pid=ImgDetMain"
                },

                new Peliculas
                {
                    idPelicula = 944,
                    nombrePelicula = "El Padrino II",
                    numeroSala = 5,
                    horario = "18:00",
                    urlPelicula = "https://mx.web.img3.acsta.net/medias/nmedia/18/68/09/06/20197890.jpg"
                },

                new Peliculas
                {
                    idPelicula = 945,
                    nombrePelicula="Bob Esponja",
                    numeroSala = 2,
                    horario = "13:00",
                    urlPelicula ="https://es.web.img3.acsta.net/medias/nmedia/18/89/75/07/20065183.jpg"
                },

                new Peliculas
                {
                    idPelicula = 946,
                    nombrePelicula = "Black Panther",
                    numeroSala = 3,
                    horario = "16:00",
                    urlPelicula = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSTaAIqCjJ4hgNdT3Rg-zNtpJ5M0x-ybwZJIA&s"
                },

                new Peliculas
                {
                    idPelicula = 947,
                    nombrePelicula = "El Rey Leon",
                    numeroSala = 4,
                    horario = "20:00",
                    urlPelicula = "https://es.web.img3.acsta.net/medias/nmedia/18/68/20/31/19785394.jpg?coixp=47&coiyp=41"
                },

                new Peliculas
                {
                    idPelicula = 948,
                    nombrePelicula = "Avatar",
                    numeroSala = 2,
                    horario = "18:30",
                    urlPelicula = "https://pics.filmaffinity.com/Avatar-208925608-large.jpg"
                },

                new Peliculas
                {
                    idPelicula = 949,
                    nombrePelicula = "Inception",
                    numeroSala = 5,
                    horario = "22:00",
                    urlPelicula = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg"
                },

                new Peliculas
                   {
                    idPelicula = 950,
                    nombrePelicula = "Titanic",
                    numeroSala = 3,
                    horario = "16:00",
                    urlPelicula = "https://m.media-amazon.com/images/I/71i6L1vZjiL.jpg"
                   },

                new Peliculas
                {
                idPelicula = 951,
                nombrePelicula = "The Matrix",
                numeroSala = 1,
                horario = "20:30",
                urlPelicula = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg"
                },

                new Peliculas
                {
                    idPelicula = 952,
                    nombrePelicula = "Interstellar",
                    numeroSala = 6,
                    horario = "19:00",
                    urlPelicula = "https://m.media-amazon.com/images/I/A1JVqNMI7UL._AC_UF894,1000_QL80_.jpg"
                },
                new Peliculas
                {
                    idPelicula = 948,
                    nombrePelicula = "El Padrino III",
                    numeroSala = 6,
                    horario = "21:00",
                    urlPelicula = "https://es.web.img3.acsta.net/medias/nmedia/18/68/09/69/20420487.jpg"
                }



            };
        }
    }
}
