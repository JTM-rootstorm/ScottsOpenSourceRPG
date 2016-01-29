using System;
using System.IO;
using System.Windows;
using Engine;

namespace ScottsOpenSourceRPG
{
    public partial class SOSCSRPG : Window
    {
        private PlayerSession _playerSession;

        public SOSCSRPG()
        {
            InitializeComponent();

            try
            {
                var gameInformationFileName = Properties.Settings.Default.GameInformation;

                if(File.Exists(gameInformationFileName))
                {
                    var gameInformation = File.ReadAllText(gameInformationFileName);

                    SetPlayerSessionGame(new Game(gameInformation));
                }
                else
                {
                    // throw exception
                }
            }
            catch(Exception ex)
            {
                // throw exception
                throw;
            }

        }

        private void SetPlayerSessionGame(Game game)
        {
            _playerSession = new PlayerSession(game);

            DataContext = _playerSession.Game;
        }

        private void MenuItem_NewGame_OnClick(object sender, RoutedEventArgs e)
        {
            StartNewGame newGame = new StartNewGame();
            newGame.Owner = this;
            newGame.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            newGame.ShowDialog();

            if(newGame.DialogResult.HasValue && newGame.DialogResult.Value)
            {
                _playerSession.SetPlayer(newGame.NewPlayer);
            }
        }

        private void MenuItem_Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_About_OnClick(object sender, RoutedEventArgs e)
        {
            var aboutScreen = new About(_playerSession.Game);
            aboutScreen.Owner = this;

            aboutScreen.ShowDialog();
        }
    }
}