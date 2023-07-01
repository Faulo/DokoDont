using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public sealed class PrintModality : MonoBehaviour {
    [SerializeField]
    TMP_Text text;

    void Update() {
        text.text = HUD.currentModality
            ? HUD.currentModality.text
            : "";
    }
}
