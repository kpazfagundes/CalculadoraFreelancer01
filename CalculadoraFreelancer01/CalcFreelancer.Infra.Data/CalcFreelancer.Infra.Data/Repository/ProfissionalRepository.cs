using CalcFreelancer.Domain.Profissionais.Repository;
using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;
namespace CalcFreelancer.Infra.Data.Repository
{
    public class ProfissionalRepository : SqLiteRepository<Profissional>, IProfissionalRepository { 
    }
}