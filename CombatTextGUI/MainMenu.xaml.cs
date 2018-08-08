using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CombatTextGUI
{
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private NavigationService GetNavService()
        {
            return NavigationService.GetNavigationService(this);
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            var nav = GetNavService();
            nav.Navigate(new Uri("NewCharCreate.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TravelBtn_Click(object sender, RoutedEventArgs e)
        {
            var nav = GetNavService();
            nav.Navigate(new Uri("Travel.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CombatBtn_Click(object sender, RoutedEventArgs e)
        {
            var nav = GetNavService();
            nav.Navigate(new Uri("Combat.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Combat Text Game",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question,
                                        MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
                Application.Current.Shutdown();
            }
        }
    }
}
