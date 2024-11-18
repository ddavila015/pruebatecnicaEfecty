using APP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            CargarListas();
            return View();
        }


        [HttpPost]
        public IActionResult Index(UsuarioDto model)
        {

            var client = new RestClient("https://localhost:44380/api");
            var request = new RestRequest("Values", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var converjson = JsonConvert.SerializeObject(model);
            request.AddParameter("application/json", converjson, ParameterType.RequestBody);
            var response = client.Execute(request);
            CargarListas();
            return View("Success");
        }

        public void CargarListas()
        {
            List<TipoDocumentosDto> lista = new List<TipoDocumentosDto>();
            lista.Add(new TipoDocumentosDto { Id = 1, Nombre = "Cedula" });
            lista.Add(new TipoDocumentosDto { Id = 2, Nombre = "Identificacion" });
            lista.Add(new TipoDocumentosDto { Id = 3, Nombre = "Cedula extranjeria" });
            ViewBag.ListaTipos = lista;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
