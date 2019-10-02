using System;
using System.Collections.Generic;
using System.IO;
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

namespace ReproductorStarWars
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name == "Trailer1RadioButton")
            {
                ReproductorMediaPlayer.Source = new Uri(@"C:\Users\alumno\source\repos\ReproductorStarWars\ReproductorStarWars\trailer1.mp4");
            }
            else if (rb.Name == "Trailer2RadioButton")
            {
                ReproductorMediaPlayer.Source = new Uri(@"C:\Users\alumno\source\repos\ReproductorStarWars\ReproductorStarWars\trailer2.mp4");
            }
            ReproductorMediaPlayer.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaPlayer.Stop();
        }

        private void SilencioCheckBox_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaPlayer.IsMuted = !ReproductorMediaPlayer.IsMuted;
        }
    }
}
