using Gerencia_tarefa.Models;

namespace Gerencia_tarefa.Repositorio
{
    public interface ITarefasRepositorio
    {
        List<Model_index> BuscarTodos(); // lista a model
        Model_index Adicionar(Model_index tarefas);
        /*
            Model_index
            - É o tipo de retorno do método.
              Significa que, ao executar Adicionar(...), o método deverá devolver um objeto do tipo Model_index.
              Normalmente esse retorno representa o registro salvo no banco, já com ID preenchido, por exemplo.

            Adicionar
            - É o nome do método. Indica a intenção da função: adicionar uma tarefa no sistema.

            (Model_index tarefas)
            - É o parâmetro recebido. Significa que o método precisa receber um objeto do tipo Model_index, chamado tarefas.
        */
    }
}
