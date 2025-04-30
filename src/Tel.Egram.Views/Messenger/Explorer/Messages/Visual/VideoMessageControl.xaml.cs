using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Explorer.Messages.Visual;

namespace Tel.Egram.Views.Messenger.Explorer.Messages.Visual;

public class VideoMessageControl : BaseControl<VideoMessageViewModel>
{
    public VideoMessageControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}