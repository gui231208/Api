﻿namespace ApiSegundoDS.models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public Aluno Aluno { get; set; }
        public Escola Escola { get; set; }
    }
}