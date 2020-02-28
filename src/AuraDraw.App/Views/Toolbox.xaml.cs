using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class Toolbox : UserControl
    {
        public Toolbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}