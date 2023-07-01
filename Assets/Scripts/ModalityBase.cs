using UnityEngine;

public abstract class ModalityBase : ScriptableObject {

    int value;

    GameObject instance;

    protected void OnEnable() {
        value = 0;
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
