using UnityEngine;

public sealed class GameClock : MonoBehaviour {
    public static float time { get; private set; } = 9;

    [SerializeField]
    int startTime = 9;

    void OnEnable() {
        time = startTime;
    }

    void Update() {
        time += Time.deltaTime;
    }
}
