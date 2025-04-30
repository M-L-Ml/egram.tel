using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Informer;

namespace Tel.Egram.Views.Messenger.Informer;

public class InformerControl : BaseControl<InformerViewModel>
{
    public InformerControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}