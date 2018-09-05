using CalcFreelancer.Domain.Projetos.Repository;
using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcFreelancer.Infra.Data.Repository
{
    public class ProjetoRepository : SqLiteRepository<Projeto>, IProjetoRepository
    {
    }
}
