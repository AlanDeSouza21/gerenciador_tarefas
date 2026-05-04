using Gerencia_tarefa.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerencia_tarefa.Data
{
    // "DbContext" é uma classe padrão / genérica do entity core. Ele representa a ponte entre sua aplicação C# e o banco de dados.
    public class BancoContext : DbContext
    {
        // CONFIGURAÇÃO PADRÃO PARA O CONSTRUTOR ENTITY CORE:
        // - o construtor deve ter o mesmo nome da classe
        // - é necessário ter um parâmetro de entrada nesse caso é "DbContextOptions"
        // - "<BancoContext>" serve para tipificar o parâmetro mostrando para o entity core que tudo declarado a frente será especificamente para essa classe
        // - "options) : base(options)" as configurações especificas dessa classe serão passadas para a classe genérica "DbContext"
        // - em resumo "DbContextOptions<BancoContext> options" é apenas um parâmetro que levara ao entity core as configurações necessárias para esse projeto
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        // "public DbSet" método que representa a tabela;
        // "Models.Model_index" classe responsável por receber os dados
        // "Tarefas" nome dado para tabela nesse caso será "Tarefas"        
        public DbSet<Model_index> Tarefas { get; set; }
    }
}
