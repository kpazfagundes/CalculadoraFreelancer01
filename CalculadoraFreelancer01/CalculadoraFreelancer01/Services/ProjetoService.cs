using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFreelancer01.Services
{
    public class ProjetoService
    {
        private readonly AzureProjetoRepository ProjetoRepository;

        public ProjetoService()
        {
            ProjetoRepository = new AzureProjetoRepository();
        }

        public void Inserir(Projeto projeto)
        {
            ProjetoRepository.Insert(projeto);
        }
    }
}
