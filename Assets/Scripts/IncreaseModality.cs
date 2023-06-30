using UnityEngine;

public class IncreaseModality : MonoBehaviour {
    [SerializeField]
    public ModalityBase modality;

    float timer;

    protected void Update() {
        timer += Time.deltaTime;
        while (timer > 1) {
            modality.Increment();
            timer--;
        }
    }
}
