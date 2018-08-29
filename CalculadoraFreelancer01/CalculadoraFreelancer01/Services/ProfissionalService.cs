using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFreelancer01.Services
{
    public class ProfissionalService
    {
        private readonly AzureRepository ProfissionalRepository;

        public ProfissionalService()
        {
            ProfissionalRepository = new AzureRepository();
        }

        public void Inserir(Profissional profissional)
        {
            ProfissionalRepository.Insert(profissional);
        }
    }
}
