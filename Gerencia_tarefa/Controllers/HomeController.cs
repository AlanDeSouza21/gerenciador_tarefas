using Gerencia_tarefa.Models;
using Gerencia_tarefa.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gerencia_tarefa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITarefasRepositorio _tarefas_repositorio; // armazena a interface "ITarefasRepositorio"
        public HomeController(ITarefasRepositorio tarefas_repositorio) // metodo com a função de fazer a interface ser usada pelas actions
        {
            _tarefas_repositorio = tarefas_repositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost] // adiciona o método post
        public IActionResult Index(Model_index tarefas) // action que conecta model e view
        {
            _tarefas_repositorio.Adicionar(tarefas); // metodo adicionar trazido pela pela interface
            return RedirectToAction("Index"); // retorna o resultado para o index
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
