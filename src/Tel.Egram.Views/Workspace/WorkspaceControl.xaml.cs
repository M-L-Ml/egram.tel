using Avalonia.Markup.Xaml;
using Tel.Egram.Model.Workspace;
using Tel.Egram.ViewModels.Workspace;

namespace Tel.Egram.Views.Workspace;

public class WorkspaceControl : BaseControl<WorkspaceViewModel>
{
    public WorkspaceControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}