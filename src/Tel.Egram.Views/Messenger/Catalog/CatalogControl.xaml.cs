using Avalonia.Markup.Xaml;
using Tel.Egram.ViewModels.Messaging.Catalog;

namespace Tel.Egram.Views.Messenger.Catalog;

public class CatalogControl : BaseControl<CatalogViewModel>
{
    public CatalogControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}