using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Editor;

namespace Tel.Egram.Views.Messenger.Editor;

public class EditorControl : BaseControl<EditorViewModel>
{
    public EditorControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}