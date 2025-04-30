using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging;

namespace Tel.Egram.Views.Messenger;

public class MessengerControl : BaseControl<MessengerViewModel>
{
    public MessengerControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}