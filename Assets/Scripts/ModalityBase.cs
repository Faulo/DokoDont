using UnityEngine;

public abstract class ModalityBase : ScriptableObject {
    [SerializeField]
    int startingValue = 0;
    [SerializeField]
    int maximumValue = 1000;

    public int value { get; private set; }

    GameObject instance;

    protected void OnEnable() {
        value = startingValue;
        instance = null;
    }

    public void Increment() {
        value++;
    }

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    public string text = "Now doing: Nothing";

    [SerializeField]
    public string unit = "";

    public string valueWithUnit => $"{value}{unit}";

    public Grade valueAsGrade {
        get {
            float grade = (float)value / maximumValue;

            return value switch {
                _ when grade >= 1f => Grade.S,
                _ when grade >= 0.9f => Grade.A,
                _ when grade >= 0.75f => Grade.B,
                _ when grade >= 0.5f => Grade.C,
                _ when grade >= 0.2f => Grade.D,
                _ => Grade.F,
            };
        }
    }

    public void TryStart(GameObject button) {
        if (CanOpen(out string errorText)) {
            HUD.currentModality = this;
        } else {
            HUD.status = errorText;
        }
    }

    public void Start() {
        instance = Instantiate(prefab);
        HUD.status = text;
    }

    public void Close() {
        if (instance) {
            Destroy(instance);
            instance = null;
        }
    }

    public abstract bool CanOpen(out string errorText);
}
