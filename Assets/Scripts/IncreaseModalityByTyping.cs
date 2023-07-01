using UnityEngine;

public sealed class IncreaseModalityByTyping : MonoBehaviour {
    [SerializeField]
    ModalityBase modality;

    void Update() {
        if (Input.anyKeyDown) {
            modality.Increment();
        }
    }
}
