﻿using CalculadoraFreelancer01.Repository;
using CalculadoraFreelancer01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculoValorHoraPage : ContentPage
    {
        public CalculoValorHoraPage()
        {
            InitializeComponent();
            var viewModel = new CalculoValorHoraPageViewModel();
            BindingContext = viewModel;
        }
    }
}