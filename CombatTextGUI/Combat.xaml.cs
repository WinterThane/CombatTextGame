using CombatTextMechanics;
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

namespace CombatTextGUI
{
    public partial class Combat : Page
    {
        private Battle battle = new Battle();
        private Attack playerAttack = new Attack();

        public Combat()
        {
            InitializeComponent();
            InitHealthManaBars();
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
            text.Content = " Name: Winter\n";
            text.Content += " Class: Ranger\n";
            text.Content += " Level: 1\n";
            text.Content += " Experience: 0";
        }

        private void PlayerAttributes_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock text = GetTextBlock(sender);
            text.Text = " Strength: " + battle.PlayerStrength() + "\n";
            text.Text += " Intelligence: " + battle.PlayerIntelligence() + "\n";
            text.Text += " Dexterity: " + battle.PlayerDexterity() + "\n";
            text.Text += " Vitality: " + battle.PlayerVitality() + "\n";
            text.Text += " Speed: " + battle.PlayerSpeed();
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

        private static TextBlock GetTextBlock(object sender)
        {
            return sender as TextBlock;
        }


        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += playerAttack.PlayerAttack() + "\n";
        }

        private void SpellButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Spell was cast! ... Proper text will be displayed here\n";
        }

        private void SkillButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Class specific skill was used! ... Proper text will be displayed here\n";
        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Defend! ... Proper text will be displayed here\n";
        }

        private void FleeButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTextBox.Text += "Flee from combat! ... Proper text will be displayed here\n";
        }
    }
}
