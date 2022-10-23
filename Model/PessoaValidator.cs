using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ValidationData.Model
{
    public class PessoaValidator : AbstractValidator<PessoaRequest>
    {
      public PessoaValidator()
      {
         RuleFor(p => p.Nome)
            .NotEmpty()
            .WithMessage("Campo obrigatório");

        RuleFor(p => p.DataNascimento)
            .LessThan(DateTime.Now)
            .WithMessage("Data inválida");
      }
    }

}