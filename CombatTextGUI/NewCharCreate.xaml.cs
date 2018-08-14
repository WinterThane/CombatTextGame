using CombatTextMechanics;
using System.Windows;
using System.Windows.Controls;
using CombatTextMechanics.Functions;

namespace CombatTextGUI
{
    public partial class NewCharCreate : Page
    {
        public ClassesInit classes = new ClassesInit();

        public NewCharCreate()
        {
            InitializeComponent();
            CharacterClassesCB.ItemsSource = classes.GetClassNames();
            InitClassStats();
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
        }

        private void PlusStrengthButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassStrengthTB.Text);
            ClassStrengthTB.Text = value.ToString();
        }

        private void PlusIntelligenceButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassIntelligenceTB.Text);
            ClassIntelligenceTB.Text = value.ToString();
        }

        private void PlusDexterityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassDexterityTB.Text);
            ClassDexterityTB.Text = value.ToString();
        }

        private void PlusVitalityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassVitalityTB.Text);
            ClassVitalityTB.Text = value.ToString();
        }

        private void PlusSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.IncreaseStat(ClassSpeedTB.Text);
            ClassSpeedTB.Text = value.ToString();
        }

        private void MinusStrengthButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassStrengthTB.Text);
            ClassStrengthTB.Text = value.ToString();
        }

        private void MinusIntelligenceButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassIntelligenceTB.Text);
            ClassIntelligenceTB.Text = value.ToString();
        }

        private void MinusDexterityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassDexterityTB.Text);
            ClassDexterityTB.Text = value.ToString();
        }

        private void MinusVitalityButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassVitalityTB.Text);
            ClassVitalityTB.Text = value.ToString();
        }

        private void MinusSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            int value = StringFunctions.DecreaseStat(ClassSpeedTB.Text);
            ClassSpeedTB.Text = value.ToString();
        }
    }
}
