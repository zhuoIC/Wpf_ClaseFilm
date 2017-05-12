﻿using System;
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

namespace NHJ.Wpf_EnlaceDatosClaseFilm
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnCambiar_Click(object sender, RoutedEventArgs e)
        {
            Film film = Resources["filmInfiltrados"] as Film;
            if (film == null)
            {
                return;
            }
            film.Titulo = "Se ha cambiado";
            film.Genero = Genero.Catatrofismo;
            film.Calificacion = 0.0;
        }
    }


}
