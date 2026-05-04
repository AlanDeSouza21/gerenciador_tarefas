namespace Gerencia_tarefa.Models
{
    public class Model_index
    {
        public int Id { get; set; }

        public string Tarefa { get; set; }

        // Representa apenas a data (dia/mês/ano)
        public DateTime Data { get; set; }

        // TimeOnly é ideal para representar apenas a hora do dia (disponível no .NET 6+)
        public TimeOnly Horario_inicio { get; set; }

        public TimeOnly Horario_fim { get; set; }

        // Se o prazo final incluir uma data específica, use DateTime
        public DateTime Prazo_final { get; set; }

    }
}
