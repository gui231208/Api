namespace ApiSegundoDS.models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public int ProfessorId { get; set; }
        public int EscolaId { get; set; }

    }
}
