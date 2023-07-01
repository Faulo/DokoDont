using UnityEngine;

public sealed class GameClock : MonoBehaviour {
    public static float time { get; private set; } = 9;
    public static bool isEnabled;

    [SerializeField]
    int startTime = 9;
    [SerializeField]
    int multiplier = 1;

    void OnEnable() {
        time = startTime;
        isEnabled = true;
    }

    void Update() {
        if (isEnabled) {
            time += Time.deltaTime * multiplier;
        }
    }
}
