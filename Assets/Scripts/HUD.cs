using UnityEngine;

public sealed class HUD : MonoBehaviour {
    [SerializeField]
    ModalityBase idlingModality;
    [SerializeField]
    ModalityBase marketingModality;
    [SerializeField]
    ModalityBase jammingModality;
    [SerializeField]
    ModalityBase sleepingModality; 

    void Start() {
        idlingModality.TryStart(default);
    }

    public static ModalityBase currentModality;
}
