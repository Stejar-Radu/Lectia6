using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Aplicatie1.models;
using Microsoft.Data.Sqlite;

namespace Aplicatie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Pasager> pasageri { get; set; }
        public List<Ruta> Rute { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            using (AlbDbContext dbContext = new AlbDbContext())
            {
                dbContext.Database.EnsureCreated();
                dbContext.Pasageri.Add(new Pasager
                {
                    Id = Guid.NewGuid().ToString(),
                    Nume = "Ciolac",
                    Prenume = "Vasilii",
                    NumarTelefon = "+373842944",
                });
                dbContext.SaveChanges();

                dbContext.Rute.Add(new Ruta
                {
                    Id = Guid.NewGuid().ToString(),
                    Destinatie = "Cahul",
                    Clasa = Clasa.Economy,
                    Pasager = dbContext.Pasageri.ToList()[0],
                    Pret = 200
                });
                dbContext.SaveChanges();
            }


        }
    }
    }

