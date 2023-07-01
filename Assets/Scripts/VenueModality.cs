using System;
using UnityEngine;

[CreateAssetMenu]
public sealed class VenueModality : ModalityBase {
    [SerializeField]
    public string errorText = "Can't do this!";

    [SerializeField]
    Vector2Int[] openingTimes = Array.Empty<Vector2Int>();

    protected override bool CanOpen(out string errorText) {
        foreach (var time in openingTimes) {
            if (time.x <= GameClock.time && GameClock.time <= time.y) {
                errorText = null;
                return true;
            }
        }

        errorText = this.errorText;
        return false;
    }
}
