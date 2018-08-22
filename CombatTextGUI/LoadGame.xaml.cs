using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Path = System.IO.Path;

namespace CombatTextGUI
{
    public partial class LoadGame : Page
    {
        public LoadGame()
        {
            InitializeComponent();
            Loaded += LoadGame_Loaded;
        }

        private void LoadGame_Loaded(object sender, RoutedEventArgs e)
        {
            var files = Directory.GetFiles(@"Data\Player\");
            foreach (var item in files)
            {
                saveFiles.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }

        private NavigationService GetNavService()
        {
            return NavigationService.GetNavigationService(this);
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadGameClick();
        }

        private void saveFiles_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoadGameClick();
        }

        private void LoadGameClick()
        {
            Application.Current.Properties["PageData"] = saveFiles.SelectedItem;
            var nav = GetNavService();
            nav.Navigate(new Uri("Travel.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void saveFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadButton.IsEnabled = true;
        }
    }
}
