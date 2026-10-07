using JetBrains.Annotations;
using Robust.Client.UserInterface;

namespace Content.Client._Impstation.Interface.ScreamingButton;

[UsedImplicitly]
public sealed class ScreamingButtonBoundUserInterface : BoundUserInterface
{
    private ScreamingButton? _window;

    public ScreamingButtonBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {

    }

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<ScreamingButton>();
    }
}
