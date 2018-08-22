using CombatTextMechanics;
using System.Windows;
using System.Windows.Controls;
using CombatTextMechanics.Functions;
using System;
using System.Windows.Navigation;

namespace CombatTextGUI
{
    public partial class NewCharCreate : Page
    {
        public ClassesInit classes = new ClassesInit();
        public Player player = new Player();
        private int statPoints = 10;

        public NewCharCreate()
        {
            InitializeComponent();
            CharacterClassesCB.ItemsSource = classes.GetClassNames();
            InitClassStats();
            StatPointsTB.Text = statPoints.ToString();
        }

        private void InitClassStats()
        {
            ClassStrengthTB.Text = "0";
            ClassIntelligenceTB.Text = "0";
            ClassDexterityTB.Text = "0";
            ClassVitalityTB.Text = "0";
            ClassSpeedTB.Text = "0";
        }

        private void CharacterClassesCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectClassText.Visibility = CharacterClassesCB.SelectedItem == null ? Visibility.Visible : Visibility.Hidden;

            var selected = CharacterClassesCB.SelectedValue.ToString();
            var classStats = classes.GetClassStats(selected);
            
            ClassStrengthTB.Text = classStats["Strength"];
            ClassIntelligenceTB.Text = classStats["Intelligence"];
            ClassDexterityTB.Text = classStats["Dexterity"];
            ClassVitalityTB.Text = classStats["Vitality"];
            ClassSpeedTB.Text = classStats["Speed"];

            EnablePlus();
            DisableMinus();
        }

        private void EnablePlusMinus()
        {
            EnablePlus();
            EnableMinus();
        }

        private void EnableMinus()
        {
            MinusStrength.IsEnabled = true;
            MinusIntelligence.IsEnabled = true;
            MinusDexterity.IsEnabled = true;
            MinusVitality.IsEnabled = true;
            MinusSpeed.IsEnabled = true;
        }

        private void EnablePlus()
        {
            PlusStrength.IsEnabled = true;
            PlusIntelligence.IsEnabled = true;
            PlusDexterity.IsEnabled = true;
            PlusVitality.IsEnabled = true;
            PlusSpeed.IsEnabled = true;
        }

        private void DisablePlusMinus()
        {
            DisablePlus();
            DisableMinus();
        }

        private void DisableMinus()
        {
            MinusStrength.IsEnabled = false;
            MinusIntelligence.IsEnabled = false;
            MinusDexterity.IsEnabled = false;
            MinusVitality.IsEnabled = false;
            MinusSpeed.IsEnabled = false;
        }

        private void DisablePlus()
        {
            PlusStrength.IsEnabled = false;
            PlusIntelligence.IsEnabled = false;
            PlusDexterity.IsEnabled = false;
            PlusVitality.IsEnabled = false;
            PlusSpeed.IsEnabled = false;
        }

        private void TogglePlusMinus()
        {
            if (statPoints <= 0)
            {
                DisablePlus();
                EnableMinus();
            }

            if(statPoints >= 1 && statPoints <= 10)
            {
                EnablePlusMinus();
            }

            if (statPoints >= 10)
            {
                EnablePlus();
                DisableMinus();
            }
        }

        private void PlusStrengthButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassStrengthTB.Text);
            ClassStrengthTB.Text = value.ToString();
            DecreadeStatPoints();
            TogglePlusMinus();
        }

        private void PlusIntelligenceButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassIntelligenceTB.Text);
            ClassIntelligenceTB.Text = value.ToString();
            DecreadeStatPoints();
            TogglePlusMinus();
        }

        private void PlusDexterityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassDexterityTB.Text);
            ClassDexterityTB.Text = value.ToString();
            DecreadeStatPoints();
            TogglePlusMinus();
        }

        private void PlusVitalityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassVitalityTB.Text);
            ClassVitalityTB.Text = value.ToString();
            DecreadeStatPoints();
            TogglePlusMinus();
        }

        private void PlusSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassSpeedTB.Text);
            ClassSpeedTB.Text = value.ToString();
            DecreadeStatPoints();
            TogglePlusMinus();
        }

        private void MinusStrengthButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassStrengthTB.Text);
            ClassStrengthTB.Text = value.ToString();
            IncreaseStatPoints();
            TogglePlusMinus();
        }

        private void MinusIntelligenceButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassIntelligenceTB.Text);
            ClassIntelligenceTB.Text = value.ToString();
            IncreaseStatPoints();
            TogglePlusMinus();
        }

        private void MinusDexterityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassDexterityTB.Text);
            ClassDexterityTB.Text = value.ToString();
            IncreaseStatPoints();
            TogglePlusMinus();
        }

        private void MinusVitalityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassVitalityTB.Text);
            ClassVitalityTB.Text = value.ToString();
            IncreaseStatPoints();
            TogglePlusMinus();
        }

        private void MinusSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassSpeedTB.Text);
            ClassSpeedTB.Text = value.ToString();
            IncreaseStatPoints();
            TogglePlusMinus();
        }

        private void DecreadeStatPoints()
        {
            int statsLeft = StringFunctions.DecreaseStat(StatPointsTB.Text);
            StatPointsTB.Text = statsLeft.ToString();
            if(statsLeft <= 0)
            {
                statPoints = 0;
            }
            else
            {
                statPoints--;
            }
            
        }

        private void IncreaseStatPoints()
        {
            int statsLeft = StringFunctions.IncreaseStat(StatPointsTB.Text);
            StatPointsTB.Text = statsLeft.ToString();
            if(statsLeft >= 10)
            {
                statPoints = 10;
            }
            else
            {
                statPoints++;
            }
        }

        private NavigationService GetNavService()
        {
            return NavigationService.GetNavigationService(this);
        }

        private void CreateNewHero_Click(object sender, RoutedEventArgs e)
        {
            player.Name = NewHeroNameTB.Text;
            player.CharacterClass = CharacterClassesCB.SelectedValue.ToString();
            player.Strength = StringFunctions.StringToInteger(ClassStrengthTB.Text);
            player.Intelligence = StringFunctions.StringToInteger(ClassIntelligenceTB.Text);
            player.Dexterity = StringFunctions.StringToInteger(ClassDexterityTB.Text);
            player.Vitality = StringFunctions.StringToInteger(ClassVitalityTB.Text);
            player.Speed = StringFunctions.StringToInteger(ClassSpeedTB.Text);

            SaveLoadJson.SaveNewHero(player);
            Application.Current.Properties["PageData"] = player.Name;

            var nav = GetNavService();
            nav.Navigate(new Uri("Travel.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
