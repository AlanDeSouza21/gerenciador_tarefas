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
            List<Model_index> tarefas = _tarefas_repositorio.BuscarTodos(); // metodo get qie usa o contrato da interface para buscar dados
            return View(tarefas); // retorna lista de dados
        }

        public IActionResult Editar(int id)
        {
            // "Model_index" declara o tipo da variavel que é exatamente uma model, isso é necessário porque o retorno no final será um objeto model
            // "tarefa" simplesmente o nome aleatório escolhido para a variável
            // "_tarefas_repositorio" acessa o método ".Editar_por_id(id)" para encontrar o Id referente a linha da tabela 
            Model_index tarefa = _tarefas_repositorio.Editar_por_id(id);

            return View(tarefa); // retorna o resultado da variável "tarefa"
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost] // adiciona o método post
        public IActionResult Index(Model_index tarefas) // action que conecta model e view
        {
            _tarefas_repositorio.Adicionar(tarefas); // metodo que utiliza o contrato da interface para adicionar trazido pela pela interface
            return RedirectToAction("Index"); // retorna o resultado para o index
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
