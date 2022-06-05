using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace YandexMusicUnofficialClient.Views;

public partial class updateToken : Window
{
    public updateToken()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}