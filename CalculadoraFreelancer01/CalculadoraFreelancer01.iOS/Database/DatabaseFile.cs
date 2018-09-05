using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CalcFreelancer.Domain.Interfaces;
using CalculadoraFreelancer01.iOS.Database;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseFile))]
namespace CalculadoraFreelancer01.iOS.Database
{
    public class DatabaseFile : IDatabaseFile
    {
        public string GetFilePath(string file)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library");
            return Path.Combine(libFolder, file);
        }
    }
}