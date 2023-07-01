using UnityEngine;

public sealed class RotateOverTime : MonoBehaviour {
    [SerializeField]
    float startTime;
    [SerializeField]
    int sign = -1;

    void OnValidate() {
        transform.eulerAngles = new(0, 0, startTime * 360 / 24);
    }

    void Update() {
        transform.eulerAngles = new(0, 0, sign * (GameClock.time + startTime) * 360 / 24);
    }
}