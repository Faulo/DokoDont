using UnityEngine;

public sealed class GameClock : MonoBehaviour {
    public static float time { get; private set; } = 9;
    public static float deltaTime;
    public static bool isEnabled;

    [SerializeField]
    ClockSettings settings;

    void OnEnable() {
        time = settings.startTime;
        isEnabled = true;
    }

    void Update() {
        if (isEnabled) {
            deltaTime = Time.deltaTime * settings.multiplier;
            time += deltaTime;
        }
    }
}
