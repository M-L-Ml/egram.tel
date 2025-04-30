using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Explorer.Messages.Visual;

namespace Tel.Egram.Views.Messenger.Explorer.Messages.Visual;

public class StickerMessageControl : BaseControl<StickerMessageViewModel>
{
    public StickerMessageControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}