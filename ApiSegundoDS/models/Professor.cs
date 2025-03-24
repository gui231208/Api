namespace ApiSegundoDS.models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? ComponenteCurricular { get; set; }
        public int EscolaId { get; set; }
        public int AlunoId { get; set; }
    }
}