using UnityEngine;

public sealed class IncreaseModality : MonoBehaviour {
    [SerializeField]
    ModalityBase modality;
    [SerializeField]
    int multiplier = 1;

    float timer;

    void Update() {
        timer += GameClock.deltaTime * multiplier;
        while (timer > 1) {
            modality.Increment();
            timer--;
        }
    }
}
