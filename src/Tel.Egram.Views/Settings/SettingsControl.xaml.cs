using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Settings;

namespace Tel.Egram.Views.Settings;

public class SettingsControl : BaseControl<SettingsViewModel>
{
    public SettingsControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}