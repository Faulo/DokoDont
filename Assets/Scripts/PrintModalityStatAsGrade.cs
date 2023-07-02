using TMPro;
using UnityEngine;

public sealed class PrintModalityStatAsGrade : MonoBehaviour {
    [SerializeField]
    TMP_Text text;

    [SerializeField]
    ModalityBase modality;

    [SerializeField]
    string template;

    void OnValidate() {
        template = text.text;
    }

    void Update() {
        text.text = template + modality.valueAsGrade.ToString();
    }
}
