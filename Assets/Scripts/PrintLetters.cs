using Slothsoft.UnityExtensions;
using TMPro;
using UnityEngine;

public sealed class PrintLetters : MonoBehaviour {
    [SerializeField]
    TMP_Text text;
    [SerializeField]
    string letters = "zzzzzZZZZZ\n";
    [SerializeField]
    ModalityBase modality;

    char randomLetter => letters.RandomElement();

    int value;
    void Update() {
        for (; value < modality.value; value++) {
            text.text += randomLetter;
        }
    }
}
