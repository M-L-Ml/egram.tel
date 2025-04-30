using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Explorer.Messages.Special;

namespace Tel.Egram.Views.Messenger.Explorer.Messages.Special;

public class DocumentMessageControl : BaseControl<DocumentMessageViewModel>
{
    public DocumentMessageControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}