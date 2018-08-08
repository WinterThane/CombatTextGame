using CombatTextMechanics;
using System.Collections.Generic;
using System.Windows.Controls;

namespace CombatTextGUI
{
    public partial class NewCharCreate : Page
    {
        public Battle battle = new Battle();
        public List<string> classes = new List<string>();

        public NewCharCreate()
        {
            InitializeComponent();
            classes = battle.GetClasses();
            CharacterClassesCB.ItemsSource = classes;
        }
    }
}
