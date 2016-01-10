using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using Engine;

namespace ScottsOpenSourceRPG
{
    public partial class About : Window
    {
        public About(Game game)
        {
            InitializeComponent();

            DataContext = game;
        }

        private void NavigateToURL(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
