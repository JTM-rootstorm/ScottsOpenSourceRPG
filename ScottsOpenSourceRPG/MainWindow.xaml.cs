using System.Windows;
using Engine;

namespace ScottsOpenSourceRPG
{
    public partial class MainWindow : Window
    {
        private readonly Game _game;

        public MainWindow()
        {
            InitializeComponent();

            _game = new Game("Scott's Open Source C# RPG", 
                "Scott's Open Source C# RPG",
                "https://github.com/ScottLilly/ScottsOpenSourceRPG", 
                0, 1, 
                "Scott Lilly", 2015);

            DataContext = _game;
        }

        private void MenuItem_Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_About_OnClick(object sender, RoutedEventArgs e)
        {
            var aboutScreen = new About(_game);
            aboutScreen.Owner = this;
            aboutScreen.ShowDialog();
        }
    }
}