using UnityEngine;

public sealed class RotateOverTime : MonoBehaviour {
    [SerializeField]
    float startTime;

    void OnValidate() {
        transform.eulerAngles = new(0, 0, startTime * 360 / 24);
    }

    void Update() {
        transform.eulerAngles = new(0, 0, (GameClock.time + startTime) * 360 / 24);
    }
}
