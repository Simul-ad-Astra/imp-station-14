using Robust.Shared.Audio;
using Robust.Shared.Serialization;

namespace Content.Shared._Impstation.ScreamingButton.Components;

[RegisterComponent]
public sealed partial class TcktorialComponent : Component
{
    [DataField("scream")]
    public SoundSpecifier Scream = new SoundCollectionSpecifier("PlantScreams");
}

[Serializable, NetSerializable]
public sealed class TcktorialUiButtonPressedMessage : BoundUserInterfaceMessage
{
    public readonly TcktorialUIButton Button;
    public TcktorialUiButtonPressedMessage(TcktorialUIButton button)
    {
        Button = button;
    }
}

[Serializable, NetSerializable]
public enum TcktorialUIButton
{
    Scream
}

[Serializable, NetSerializable]
public enum ScreamingButtonUiKey
{
    Key
}
