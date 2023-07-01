using UnityEngine;

[CreateAssetMenu]
public sealed class IdleModality : ModalityBase {
    protected override bool CanOpen() => true;
}
