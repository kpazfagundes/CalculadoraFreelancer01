﻿using CalculadoraFreelancer01.Repository;
using CalculadoraFreelancer01.ViewModels;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer01
{
    public partial class ProjetoPage : ContentPage
    {
        public ProjetoPage()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<ProjetoPageViewModel>();
            BindingContext = viewModel;
        }

    }
}