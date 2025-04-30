using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Explorer.Homepage;

namespace Tel.Egram.Views.Messenger.Homepage;

public class HomepageControl : BaseControl<HomepageViewModel>
{   
    public HomepageControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}