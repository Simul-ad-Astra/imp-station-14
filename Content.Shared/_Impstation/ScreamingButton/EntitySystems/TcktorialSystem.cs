using Content.Shared._Impstation.ScreamingButton.Components;
using Robust.Shared.Audio.Systems;

namespace Content.Shared._Impstation.ScreamingButton.EntitySystems;

public sealed partial class TcktorialSystem : EntitySystem
{
    [Dependency] private SharedAudioSystem _audioSystem = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<TcktorialComponent, TcktorialUiButtonPressedMessage>(OnUiButtonPressed);
    }

    private void OnUiButtonPressed(Entity<TcktorialComponent> entity, ref TcktorialUiButtonPressedMessage msg)
    {
        switch (msg.Button)
        {
            case TcktorialUIButton.Scream:
                _audioSystem.PlayPvs(entity.Comp.Scream, entity.Owner);
                break;
        }
    }
}
