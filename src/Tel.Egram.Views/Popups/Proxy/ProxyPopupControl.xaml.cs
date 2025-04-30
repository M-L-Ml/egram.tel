using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Settings.Proxy;

namespace Tel.Egram.Views.Popups.Proxy;

public class ProxyPopupControl : BaseControl<ProxyPopupContext>
{   
    public ProxyPopupControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}