using CombatTextMechanics;
using CombatTextMechanics.Functions;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace CombatTextGUI
{
    public partial class Travel : Page
    {
        public Travel()
        {
            InitializeComponent();
            InitHealthManaBars();
            TravelTextBox.Text = StringFunctions.GetIntro();
        }

        private void InitHealthManaBars()
        {
            PlayerLife.Width = 158;
            PlayerLife.Height = 21;
            PlayerLife.Fill = new SolidColorBrush(Color.FromRgb(120, 0, 0));

            PlayerMana.Width = 99;
            PlayerMana.Height = 23;
            PlayerMana.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 200));
        }

        private void PlayerImage_Loaded(object sender, RoutedEventArgs e)
        {
            var pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(@"\Images\Player\Player_1.jpg", UriKind.Relative);
            pic.EndInit();

            var image = sender as Image;
            image.Source = pic;
        }

        private void PlayerMainStats_Loaded(object sender, RoutedEventArgs e)
        {
            Label text = GetLabel(sender);
            text.Content = " Name: " + Player.PlayerName() + "\n";
            text.Content += " Class: " + Player.PlayerClass() + "\n";
            text.Content += " Level: 1\n";
            text.Content += " Experience: 0";
        }

        private void PlayerAttributes_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock text = GetTextBlock(sender);
            text.Text = " Strength: " + Player.PlayerStrength() + "\n";
            text.Text += " Intelligence: " + Player.PlayerIntelligence() + "\n";
            text.Text += " Dexterity: " + Player.PlayerDexterity() + "\n";
            text.Text += " Vitality: " + Player.PlayerVitality() + "\n";
            text.Text += " Speed: " + Player.PlayerSpeed();
        }

        private void PlayerAttackStats_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock text = GetTextBlock(sender);
            text.Text = " Melee damage: 2 - 4\n";
            text.Text += " Magic power: 2\n";
            text.Text += " Initiation: 50\n";
            text.Text += " Chance to hit: 75%\n";
            text.Text += " Critical chance: 15%\n";
            text.Text += " Critical damage: 150%\n";
            text.Text += " Number of attacks: 1";
        }

        private void PlayerDefenseStats_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock text = GetTextBlock(sender);
            text.Text = " Defense: 10\n";
            text.Text += " Armor: 5\n";
            text.Text += " Fire resistance: 10%\n";
            text.Text += " Water resistance: 5%\n";
            text.Text += " Air resistance: 0%\n";
            text.Text += " Earth resistance: 15%";
        }

        private static Label GetLabel(object sender)
        {
            return sender as Label;
        }

        private static TextBlock GetTextBlock(object sender)
        {
            return sender as TextBlock;
        }

        private void NorthButton_Click(object sender, RoutedEventArgs e)
        {
            TravelTextBox.Text += "You walk north ... Proper text will be displayed here\n";
        }

        private void WestButton_Click(object sender, RoutedEventArgs e)
        {
            TravelTextBox.Text += "You walk west ... Proper text will be displayed here\n";
        }

        private void EastButton_Click(object sender, RoutedEventArgs e)
        {
            TravelTextBox.Text += "You walk east ... Proper text will be displayed here\n";
        }  

        private void SouthButton_Click(object sender, RoutedEventArgs e)
        {
            TravelTextBox.Text += "You walk south ... Proper text will be displayed here\n";
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void RestButton_Click(object sender, RoutedEventArgs e)
        {
            TravelTextBox.Text += "You rest for few hours to replanish your health and mana ... Proper text will be displayed here\n";
        }
    }
}
