﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.Entities
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        
        public bool Disponivel { get; set; }
        
        public bool Ead { get; set; }

        //public List<Aluno> Alunos { get; set; }

    }
}
