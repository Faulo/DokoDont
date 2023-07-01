using TMPro;
using UnityEngine;

public sealed class PrintModalityStat : MonoBehaviour {
    [SerializeField]
    TMP_Text text;

    [SerializeField]
    ModalityBase modality;

    void Update() {
        text.text = modality.valueWithUnit.Trim();
    }

    void OnValidate() {
        text.text = modality.valueWithUnit.Trim();
    }
}
