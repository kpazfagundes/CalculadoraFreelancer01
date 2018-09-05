using CalcFreelancer.Domain.Profissionais.Repository;
using CalculadoraFreelancer01.Interfaces;
using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;

namespace CalculadoraFreelancer01.Services
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly IProfissionalRepository ProfissionalRepository;

        public ProfissionalService(IProfissionalRepository profissionalRepository)
        {
            ProfissionalRepository = profissionalRepository;
        }

        public void Inserir(Profissional profissional)
        {
            ProfissionalRepository.Insert(profissional);
        }
    }
}
