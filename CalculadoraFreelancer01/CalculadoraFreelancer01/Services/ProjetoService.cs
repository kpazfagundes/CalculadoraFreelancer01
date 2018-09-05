using CalcFreelancer.Domain.Projetos.Repository;
using CalculadoraFreelancer01.Interfaces;
using CalculadoraFreelancer01.Models;
using CalculadoraFreelancer01.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFreelancer01.Services
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository ProjetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            ProjetoRepository = projetoRepository;
        }

        public void Inserir(Projeto projeto)
        {
            ProjetoRepository.Insert(projeto);
        }
    }
}
