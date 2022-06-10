using AudioMonitor.Components.MainPage;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AudioMonitor
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainPageView
                {
                    DataContext = new MainPageViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
