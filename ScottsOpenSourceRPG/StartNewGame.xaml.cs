using System.Collections.Generic;
using System.Windows;
using Engine;
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

            var races = new Dictionary<Races, string>();

            foreach(var enumValue in typeof(Races).GetEnumValues())
            {
                races.Add((Races)enumValue, enumValue.ToString().InLocalizedLanguage());
            }

            cboRaces.IsReadOnly = true;
            cboRaces.ItemsSource = races;
            cboRaces.SelectedValuePath = "Key";
            cboRaces.DisplayMemberPath = "Value";

            var playerClasses = new Dictionary<PlayerClasses, string>();

            foreach(var enumValue in typeof(PlayerClasses).GetEnumValues())
            {
                playerClasses.Add((PlayerClasses)enumValue, enumValue.ToString().InLocalizedLanguage());
            }

            cboPlayerClasses.IsReadOnly = true;
            cboPlayerClasses.ItemsSource = playerClasses;
            cboPlayerClasses.SelectedValuePath = "Key";
            cboPlayerClasses.DisplayMemberPath = "Value";

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

            cboRaces.SelectedValue = NewPlayer.Race;
            cboPlayerClasses.SelectedValue = NewPlayer.PlayerClass;
        }
    }
}
