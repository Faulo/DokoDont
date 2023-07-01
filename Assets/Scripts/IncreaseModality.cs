using UnityEngine;

public sealed class IncreaseModality : MonoBehaviour {
    [SerializeField]
    public ModalityBase modality;

    float timer;

    void Update() {
        timer += Time.deltaTime;
        while (timer > 1) {
            modality.Increment();
            timer--;
        }
    }
}
