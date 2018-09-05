using CalcFreelancer.Domain.Profissionais.Repository;
using CalcFreelancer.Domain.Projetos.Repository;
using CalcFreelancer.Infra.Data.Repository;
using CalculadoraFreelancer01.Interfaces;
using CalculadoraFreelancer01.Services;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;

namespace CalculadoraFreelancer01
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<IProjetoRepository, ProjetoRepository>();
            unityContainer.RegisterType<IProfissionalRepository, ProfissionalRepository>();

            unityContainer.RegisterType<IProjetoService, ProjetoService>();
            unityContainer.RegisterType<IProfissionalService, ProfissionalService>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
