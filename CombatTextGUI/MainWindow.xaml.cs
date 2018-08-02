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
using CombatTextMechanics;

namespace CombatTextGUI
{
    public partial class MainWindow : Window
    {
        private Battle battle = new Battle();

        public MainWindow()
        {
            InitializeComponent();
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

        private void PlayerNameLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Name: Winter";
        } 

        private void PlayerStrengthLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Strength: " + battle.PlayerStrength();
        }
        
        private void PlayerIntelligenceLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Intelligence: " + battle.PlayerIntelligence();
        }

        private void PlayerVitalityLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Vitality: " + battle.PlayerVitality();
        }

        private void PlayerSpeedLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Speed: " + battle.PlayerSpeed();
        }


        private void EnemyImage_Loaded(object sender, RoutedEventArgs e)
        {
            var pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(@"\Images\Enemy\Enemy_1.jpg", UriKind.Relative);
            pic.EndInit();

            var image = sender as Image;
            image.Source = pic;
        }

        private void EnemyNameLabel_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = GetLabel(sender);
            label.Content = "Name: Succubus";
        }


        private static Label GetLabel(object sender)
        {
            return sender as Label;
        }


        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Combat Text Game", 
                                        MessageBoxButton.YesNo, 
                                        MessageBoxImage.Question, 
                                        MessageBoxResult.No);

            if(result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Attack! ... Proper text will be displayed here\n";
        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Defend! ... Proper text will be displayed here\n";
        }
    }
}
