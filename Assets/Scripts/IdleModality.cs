using UnityEngine;

[CreateAssetMenu]
public sealed class IdleModality : ModalityBase {
    [SerializeField]
    public string errorText = "Can't do this!";

    public override bool CanOpen(out string errorText) {
        errorText = "";
        return true;
    }
}
