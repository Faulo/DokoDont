using TMPro;
using UnityEngine;

public sealed class PrintModalityStatAsText : MonoBehaviour {
    [SerializeField]
    ModalityBase modality;
    [SerializeField]
    TextAsset asset;
    [SerializeField]
    TMP_Text text;

    int value = -1;

    void Update() {
        if (value != modality.value) {
            value = modality.value;
            text.text = asset.text[..value];
        }
    }
}
