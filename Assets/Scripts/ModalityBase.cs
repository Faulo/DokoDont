using UnityEngine;

public abstract class ModalityBase : ScriptableObject {
    int value;

    public void Increment() {
        value++;
    }

    [SerializeField]
    GameObject prefab;

    GameObject instance;
    public void TryStart(GameObject button) {
        if (CanOpen()) {
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
