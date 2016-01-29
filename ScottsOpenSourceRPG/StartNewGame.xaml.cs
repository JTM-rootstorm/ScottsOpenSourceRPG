using System.Windows;

using Engine.Entities;

namespace ScottsOpenSourceRPG
{
    public partial class StartNewGame : Window
    {
        private Player _player;

        public Player NewPlayer
        {
            get { return _player; }
            set
            {
                _player = value;
                DataContext = _player;
            }
        }

        public StartNewGame()
        {
            InitializeComponent();

            CreateNewPlayer();
        }

        private void NewCharacter_Button_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPlayer();
        }

        private void Accept_Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void CreateNewPlayer()
        {
            NewPlayer = Player.CreateRandomPlayer("");
        }
    }
}
