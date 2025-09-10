using Microsoft.AspNetCore.Mvc;
using System.Web; // para HttpUtility
using Dominio;

namespace PagWebMajo.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly Quince quince;
        private readonly IWebHostEnvironment fotosMuchas;

        public IActionResult InicioPresentacion()
        {
            // Ruta física a la carpeta de fotos/videos
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Servicios", "Presentacion");

            // Lista con todas las rutas web de los archivos encontrados (si necesitás listar fotos, sino podés sacar esto)
            var archivos = Directory.GetFiles(ruta)
                .Select(f => "/Servicios/Presentacion/" + Path.GetFileName(f))
                .ToList();

            return View(); // No necesitamos pasar archivos si solo vas a mostrar una foto fija
        }

        public IActionResult NuestrosServicios()
        {
            return View();
        }

        public IActionResult VistaInicialFotos()
        {
            // Ruta física a la carpeta de fotos/videos
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Servicios", "Fotos");

            // Lista con todas las rutas web de los archivos encontrados
            var archivos = Directory.GetFiles(ruta)
                .Select(f => "/Servicios/Fotos/" + Path.GetFileName(f))
                .ToList();

            return View(archivos); // Pasamos la lista a la vista
        }

        public IActionResult VistaInicialBarra()
        {
            // Ruta física a la carpeta de fotos/videos
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Servicios", "Barra");

            // Lista con todas las rutas web de los archivos encontrados
            var archivos = Directory.GetFiles(ruta)
                .Select(f => "/Servicios/Barra/" + Path.GetFileName(f))
                .ToList();

            return View(archivos); // Pasamos la lista a la vista
        }


        public IActionResult VistaInicialCabina()
        {
            // Ruta física a la carpeta de fotos/videos
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Servicios", "Cabina");

            // Lista con todas las rutas web de los archivos encontrados
            var archivos = Directory.GetFiles(ruta)
                .Select(f => "/Servicios/Cabina/" + Path.GetFileName(f))
                .ToList();

            return View(archivos); // Pasamos la lista a la vista
        }

        public IActionResult VistaInicialVideo()
        {
            // Ruta física a la carpeta de fotos/videos
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Servicios", "Video");

            // Lista con todas las rutas web de los archivos encontrados
            var archivos = Directory.GetFiles(ruta)
                .Select(f => "/Servicios/Video/" + Path.GetFileName(f))
                .ToList();

            return View(archivos); // Pasamos la lista a la vista
        }




    }
}
