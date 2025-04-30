using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Explorer.Messages.Basic;

namespace Tel.Egram.Views.Messenger.Explorer.Messages.Basic;

public class TextMessageControl : BaseControl<TextMessageViewModel>
{
    public TextMessageControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}