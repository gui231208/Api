﻿namespace ApiSegundoDS.models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public int AlunoId { get; set; }
        public int ProfessorId { get; set; }

    }
}