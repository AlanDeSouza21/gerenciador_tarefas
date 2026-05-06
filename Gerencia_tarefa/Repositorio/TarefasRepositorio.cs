using Gerencia_tarefa.Data;
using Gerencia_tarefa.Models;

namespace Gerencia_tarefa.Repositorio
{
    public class TarefasRepositorio : ITarefasRepositorio
    {
        private readonly BancoContext _bancoContext; // aqui é armazenado o contexto do "BancoContext.cs" que será usado pelo construtor abaixo

        public TarefasRepositorio(BancoContext banco_context) // a função desse construtor é injetar na classe "TarefasRepositorio.cs" o contexto do banco de dados (BancoContext.cs) 
        {
            _bancoContext = banco_context; // com ajuda do script que foi inserido no "Program.cs"
        }

        public Model_index Editar_por_id(int id)
        {
            return _bancoContext.Tarefas.FirstOrDefault(x => x.Id == id); // Pegue o primeiro registro onde o Id seja igual ao id informado
        }

        public List<Model_index> BuscarTodos()
        {
            return _bancoContext.Tarefas.ToList(); // retorna, "_bancoContext.Tarefas" retorna a tabela Tarefas em formato de lista
        }
        
        public Model_index Adicionar(Model_index tarefas) // metodo para adicionar dados na tabela, salvar adição e retornar os dados 

        {
            _bancoContext.Tarefas.Add(tarefas); // "Tarefas" é a tabela que recebe os dados, a função dessa linha é adiconar dados
            _bancoContext.SaveChanges(); // salva a adição de dados
            return tarefas; // retorna os dados
        }

    }
}
