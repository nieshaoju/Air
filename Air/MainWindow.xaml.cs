using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Air
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thickness rect_raw_margin;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void StartAnimation()
        {
            /*Storyboard sb = new();
                        var thicknessAnimation = new ThicknessAnimation
                        {
                            Duration = new Duration(TimeSpan.FromMilliseconds(2000)),
                            From = rect_raw_margin,
                            To = new Thickness(border.Width, rect.Margin.Top,
                                -rect.Width, rect.Margin.Bottom),
                            RepeatBehavior = RepeatBehavior.Forever,
                        };
                        Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));
                        sb.Children.Add(thicknessAnimation);
                        sb.Begin(rect);*/
        }

        async Task cw()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            button.IsEnabled = false;
            try
            {
                await cw();
            }
            finally
            {
                button.IsEnabled = true;
            }
            return;
            var demo = new Demo();
            demo.ShowDialog();
        }

    }
}