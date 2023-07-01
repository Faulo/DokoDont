using TMPro;
using UnityEngine;

public sealed class WriteClock : MonoBehaviour {
    [SerializeField]
    TMP_Text text;

    void Update() {
        int day = (int)(GameClock.time / 24);
        int hour = (int)(GameClock.time - (day * 24));
        int minute = (int)((GameClock.time - (day * 24) - hour) * 60);

        string dow = day switch {
            0 => "Fr",
            1 => "Sa",
            _ => "So",
        };
        text.text = $"{dow}, {hour:D2}:{minute:D2}";
    }
}
