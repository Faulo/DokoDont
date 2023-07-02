using UnityEngine;

[CreateAssetMenu]
public sealed class ClockSettings : ScriptableObject {
    [SerializeField]
    public int startTime = 9;
    [SerializeField]
    public int multiplier = 1;

    public void OpenUrl(string url) {
        Application.OpenURL(url);
    }
}
