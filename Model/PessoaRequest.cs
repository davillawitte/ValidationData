using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationData.Model
{
    public class PessoaRequest
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public bool EhEmancipada { get; set; }

        public List<string> Filiacao { get; set; }
    }
}