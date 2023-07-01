using UnityEngine;

public abstract class ModalityBase : ScriptableObject {

    int value;

    public void Increment() {
        value++;
    }

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    public string text = "Now doing: Nothing";

    GameObject instance;

    public void TryStart(GameObject button) {
        if (!instance && CanOpen()) {
            HUD.currentModality = this;
            instance = Instantiate(prefab);
        }
    }

    public void TryClose() {
        if (instance) {
            Destroy(instance);
            instance = null;
        }
    }

    protected abstract bool CanOpen();
}
