using TMPro;
using UnityEngine;

public sealed class PrintResult : MonoBehaviour {
    [SerializeField]
    TMP_Text text;

    [SerializeField]
    string template;
    [SerializeField]
    ResultsAsset results;

    void OnValidate() {
        template = text.text;
    }

    void OnEnable() {
        if (results.TryLookupResult(out string result)) {
            text.text = template + result;
        }
    }
}
